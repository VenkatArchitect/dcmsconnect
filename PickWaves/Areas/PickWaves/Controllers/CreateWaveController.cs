﻿using DcmsMobile.PickWaves.Helpers;
using DcmsMobile.PickWaves.Repository.CreateWave;
using DcmsMobile.PickWaves.ViewModels;
using DcmsMobile.PickWaves.ViewModels.CreateWave;
using EclipseLibrary.Mvc.Controllers;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace DcmsMobile.PickWaves.Areas.PickWaves.Controllers
{
    [AuthorizeEx("Managing Pick Waves requires role {0}", Roles = ROLE_WAVE_MANAGER)]
    public partial class CreateWaveController : PickWavesControllerBase
    {
        #region Intialization
        /// <summary>
        /// Required by T4MVC
        /// </summary>
        public CreateWaveController()
        {

        }

        private CreateWaveService _service;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (_service == null)
            {
                _service = new CreateWaveService(this.HttpContext.Trace,
                    HttpContext.User.IsInRole(ROLE_WAVE_MANAGER) ? HttpContext.User.Identity.Name : string.Empty,
                    Request.UserHostName ?? Request.UserHostAddress
                    );
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_service != null)
            {
                _service.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        /// <summary>
        /// Applies {0:d} to date time values. Otherwise leaves the value alone
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string FormatDimensionValue(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            if (value is DateTime)
            {
                return string.Format("{0:d}", value);
            }
            return value.ToString();
        }

        private const string COOKIE_PICKWAVE = "PICKWAVE_ALL_COOKIES";

        private const string COOKIE_ROW_DIMENSION = "SELECTED_ROW_DIMENSION";
        private const string COOKIE_COL_DIMENSION = "SELECTED_COL_DIMENSION";

        /// <summary>
        /// Populates the passed PickslipMatrixPartialViewModel
        /// </summary>
        /// <param name="model"> </param>
        /// <param name="customerId"> </param>
        /// <param name="selectedRowDimension"> </param>
        /// <param name="selectedColumnDimension"> </param>
        /// <returns></returns>
        private void PopulatePickslipMatrixPartialModel(PickslipMatrixPartialViewModel model, string customerId, int selectedRowDimension, int selectedColumnDimension)
        {
            model.CustomerId = customerId;
            model.RowDimIndex = selectedRowDimension;
            model.ColDimIndex = selectedColumnDimension;
            var pdimRow = (PickslipDimension)Enum.Parse(typeof(PickslipDimension), selectedRowDimension.ToString());
            var pdimCol = (PickslipDimension)Enum.Parse(typeof(PickslipDimension), selectedColumnDimension.ToString());

            model.RowDimDisplayName = PickWaveHelpers.GetEnumMemberAttributes<PickslipDimension, DisplayAttribute>()[pdimRow].Name;
            model.ColDimDisplayName = PickWaveHelpers.GetEnumMemberAttributes<PickslipDimension, DisplayAttribute>()[pdimCol].Name;
            model.VwhList = from item in _service.GetVWhListOfCustomer(customerId)
                            select new SelectListItem
                                {
                                    Text = item.VWhId + " : " + item.Description,
                                    Value = item.VWhId,
                                    Selected = item.VWhId == model.VwhId
                                };
            if (string.IsNullOrEmpty(model.VwhId))
            {
                model.VwhId = model.VwhList.Select(p => p.Value).First();
            }
            var orders = _service.GetOrderSummary(customerId, model.VwhId, pdimRow, pdimCol);

            const int MAX_COL_DIMENSIONS = 30;
            var first = orders.Item2;

            model.RowDimensionList = (from kvp in PickWaveHelpers.GetEnumMemberAttributes<PickslipDimension, DisplayAttribute>()
                                      let count = first[kvp.Key]
                                      select new SelectListItem
                                      {
                                          Value = ((int)(kvp.Key)).ToString(),
                                          Text = string.Format("{0} ({1:N0})", kvp.Value.Name, count)
                                      }).OrderBy(p => p.Text).ToArray();

            // Dimensions which have too many distinct values are not displayed as column dimensions
            model.ColDimensionList = (from kvp in PickWaveHelpers.GetEnumMemberAttributes<PickslipDimension, DisplayAttribute>()
                                      let count = first[kvp.Key]
                                      where count <= MAX_COL_DIMENSIONS
                                      select new SelectListItem
                                      {
                                          Value = ((int)(kvp.Key)).ToString(),
                                          Text = string.Format("{0} ({1:N0})", kvp.Value.Name, count)
                                      }).OrderBy(p => p.Text).ToArray();

            model.Rows = (from order in orders.Item1
                          select new RowDimensionModel
                          {
                              PickslipCounts = order.PickslipCounts.Select(p => new
                              {
                                  Key = FormatDimensionValue(p.Key),
                                  Value = p.Value
                              }).ToDictionary(p => p.Key, p => p.Value),
                              DimensionValue = FormatDimensionValue(order.DimensionValue)
                          }).ToArray();
        }


        /// <summary>
        /// Showing list of dimension and their pickslip count for passed customer and dimension.
        /// </summary>
        /// <param name="model">
        /// Posted value
        /// SelectedDimension,CustomerId
        /// </param>       
        /// <returns></returns>
        public virtual ActionResult Index(IndexViewModel model)
        {
            PopulatePickslipMatrixPartialModel(model, model.CustomerId, model.RowDimIndex.Value, model.ColDimIndex.Value);

            //Showing only those area where order of customer are available.
            var areas = _service.GetAreasForCustomer(model.CustomerId);
            if (areas != null)
            {
                model.PullAreas = (from area in areas
                                   where area.AreaType == BucketActivityType.Pulling && area.CountSku > 0
                                   orderby area.CountSku descending
                                   select new SelectListItem
                                   {
                                       Text = string.Format("{0}: {1} ({2:N0}% SKUs available)", area.ShortName ?? area.AreaId, area.Description, area.CountOrderedSku == 0 ? 0 : area.CountSku * 100 / area.CountOrderedSku),
                                       Value = area.AreaId
                                   }).ToList();

                model.PitchAreas = (from area in areas
                                    where area.AreaType == BucketActivityType.Pitching && area.CountSku > 0
                                    orderby area.CountSku descending
                                    select new SelectListItem
                                    {
                                        Text = string.Format("{0}: {1} ({2:N0}% SKUs assigned.)", area.ShortName ?? area.AreaId, area.Description, area.CountOrderedSku == 0 ? 0 : area.CountSku * 100 / area.CountOrderedSku),
                                        Value = area.AreaId
                                    }).ToList();

                if (model.PullAreas.Count == 0 && areas.Where(p => p.AreaType == BucketActivityType.Pulling).Count() > 0)
                {
                    // Pull areas exist but none of them have SKUs available
                    model.PullAreas.Add(new SelectListItem
                    {
                        Text = "(Ordered SKUs are not available in any Pull Area)",
                        Value = "",
                        Selected = true
                    });
                }

                if (model.PitchAreas.Count == 0 && areas.Where(p => p.AreaType == BucketActivityType.Pitching).Count() > 0)
                {
                    // Pitch areas exist but none of them have SKUs assigned
                    model.PitchAreas.Add(new SelectListItem
                    {
                        Text = "(Ordered SKUs are not assigned in any Pitch Area)",
                        Value = "",
                        Selected = true
                    });
                }
            }

            #region Manage Cookie
            //  SelectedDimension : If null, then a reasonable default is used. The default is cookie => factory default
            //  If non null, then it is used and written to a cookie.
            var cookie = Request.Cookies[COOKIE_PICKWAVE];

            if (model.RowDimIndex == null || model.ColDimIndex == null)
            {
                // Read cookie
                int dimRowIndex, dimColIndex;
                if (cookie != null && cookie[COOKIE_ROW_DIMENSION] != null && int.TryParse(cookie[COOKIE_ROW_DIMENSION], out dimRowIndex) &&
                    int.TryParse(cookie[COOKIE_COL_DIMENSION], out dimColIndex))
                {
                    model.RowDimIndex = dimRowIndex;
                    model.ColDimIndex = dimColIndex;
                }
            }
            else
            {
                // Write cookie
                if (cookie == null)
                {
                    cookie = new HttpCookie(COOKIE_PICKWAVE) { Expires = DateTime.Now.AddDays(7) };
                    cookie.Values.Add(COOKIE_ROW_DIMENSION, model.RowDimIndex.ToString());
                    cookie.Values.Add(COOKIE_COL_DIMENSION, model.ColDimIndex.ToString());
                }
                else
                {
                    if (cookie[COOKIE_ROW_DIMENSION] != null)
                        cookie.Values.Set(COOKIE_ROW_DIMENSION, model.RowDimIndex.ToString());
                    if (cookie[COOKIE_COL_DIMENSION] != null)
                        cookie.Values.Set(COOKIE_COL_DIMENSION, model.ColDimIndex.ToString());
                }
                HttpContext.Response.Cookies.Add(cookie);
            }

            #endregion

            model.CustomerName = (_service.GetCustomer(model.CustomerId) == null ? "" : _service.GetCustomer(model.CustomerId).Name);

            // If Bucket is created.
            if (model.LastBucketId.HasValue)
            {
                // Retrive some information of bucket.
                var bucket = _service.GetEditableBucket(model.LastBucketId.Value);
                if (bucket != null)
                {
                    model.PullAreaShortName = bucket.PullAreaShortName;
                    model.PitchAreaShortName = bucket.PitchAreaShortName;
                    model.PickslipCount = bucket.PickslipCount;
                }
                else
                {
                    model.LastBucketId = null;
                }
            }
            return View(Views.Index, model);
        }

        /// <summary>
        /// Ajax call : This method refreshes the pickslip list, when change dimension value.
        /// </summary>
        /// <param name="model">
        /// Posted value
        /// </param>
        /// <returns></returns>
        /// <remarks>
        /// Need to refresh the pickslip list every time after wave creation. i.e [OutputCache(Duration = 0)]
        /// </remarks>
        [OutputCache(Duration = 0)]
        public virtual ActionResult RefreshPickslipMatrix(PickslipMatrixPartialViewModel model)
        {
            PopulatePickslipMatrixPartialModel(model, model.CustomerId, model.RowDimIndex.Value, model.ColDimIndex.Value);
            var html = RenderPartialViewToString(this.Views._pickslipMatrixPartial, model);
            return Content(html);
        }

        /// <summary>
        /// Add pickslips to passed bucket.Or if bucket is not created then create it first, then add pickslip.
        /// </summary>
        /// <param name="model">
        /// RowDimIndex,ColDimIndex,CustomerId,LastBucketId
        /// Optional : RequiredBoxExpediting,PullAreaId,PitchAreaId,QuickPitch
        /// </param>
        /// <param name="viewPickslips">
        /// Showing the pickslip list
        /// </param>
        /// <returns></returns>
        [HttpPost]
        public virtual ActionResult AddPickslipsOfDim(IndexViewModel model, string viewPickslips)
        {
            // If user want to see pickslip list.
            if (!string.IsNullOrWhiteSpace(viewPickslips))
            {
                return RedirectToAction(MVC_PickWaves.PickWaves.CreateWave.PickslipList(new PickslipListViewModel
                {
                    BucketId = model.LastBucketId.Value,
                    RowDimIndex = model.RowDimIndex,
                    ColDimIndex = model.ColDimIndex,
                    RowDimVal = model.RowDimVal,
                    ColDimVal = model.ColDimVal,
                    CustomerId = model.CustomerId
                }));
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction(MVC_PickWaves.PickWaves.CreateWave.Index(model));
            }

            var pdimRow = (PickslipDimension)Enum.Parse(typeof(PickslipDimension), model.RowDimIndex.ToString());
            var pdimCol = (PickslipDimension)Enum.Parse(typeof(PickslipDimension), model.ColDimIndex.ToString());

            // If bucket is not created.create it first.
            if (!model.LastBucketId.HasValue)
            {
                var bucket = new PickWaveEditable
                {
                    PriorityId = 1,   // Default priority
                    QuickPitch = model.QuickPitch
                };

                // Give pull area if user wants to pulled cartons.
                bucket.PullAreaId = model.PullAreaId;

                // Give pitch area if user wants to pitched pieces.
                bucket.PitchAreaId = model.PitchAreaId;

                // Update Bucket name default. it change when pickslip is added to this bucket.
                bucket.BucketName = "Bucket";

                if (string.IsNullOrWhiteSpace(model.PullAreaId))
                {
                    // This bucket is not pulling buccket.
                    bucket.PullingBucket = null;
                }
                else
                {
                    if (model.RequiredBoxExpediting)
                    {
                        // Bucket is pull and Required Box Expediting (ADREPPWSS)
                        bucket.PullingBucket = "N";
                    }
                    else
                    {
                        // Pulling bucket , ADRE bucket
                        bucket.PullingBucket = "Y";
                    }
                }
                //Now Create bucket
                model.LastBucketId = _service.CreateWave(bucket, model.CustomerId, pdimRow, model.RowDimVal, pdimCol, model.ColDimVal, model.VwhId);
            }
            else
            {
                // Add pickslip to bucket 
                _service.AddPickslipsPerDim(model.LastBucketId.Value, model.CustomerId, pdimRow, model.RowDimVal, pdimCol, model.ColDimVal, model.VwhId);
            }
            return RedirectToAction(this.Actions.Index(model));
        }

        /// <summary>
        /// Get pickslip list of passed criteria.
        /// </summary>
        /// <param name="model">
        /// model.CustomerId, model.RowDimIndex, model.ColDimIndex, model.RowDimVal, model.ColDimVal,model.BucketId
        /// </param
        /// <returns></returns>
        public virtual ActionResult PickslipList(PickslipListViewModel model)
        {
            if (string.IsNullOrEmpty(model.CustomerId))
            {
                throw new ArgumentNullException("customerId");
            }
            var pdimRow = (PickslipDimension)Enum.Parse(typeof(PickslipDimension), model.RowDimIndex.ToString());
            var pdimCol = (PickslipDimension)Enum.Parse(typeof(PickslipDimension), model.ColDimIndex.ToString());

            // Pickslip list of passed dimension.
            var pickslips = _service.GetPickslipList(model.CustomerId, pdimRow, model.RowDimVal, pdimCol, model.ColDimVal);
            model.PickslipList = (from pickslip in pickslips
                                  select new PickslipModel
                                  {
                                      PickslipId = pickslip.PickslipId,
                                      PurchaseOrder = pickslip.PurchaseOrder,
                                      VwhId = pickslip.VwhId,
                                      CancelDate = pickslip.CancelDate,
                                      PickslipImportDate = pickslip.PickslipImportDate,
                                      StartDate = pickslip.StartDate,
                                      CustomerDcId = pickslip.CustomerDcId,
                                      CustomerStoreId = pickslip.CustomerStoreId
                                  }).ToArray();
            model.ManagerRoleName = ROLE_WAVE_MANAGER;

            model.RowDimDisplayName = PickWaveHelpers.GetEnumMemberAttributes<PickslipDimension, DisplayAttribute>()[pdimRow].Name;
            model.ColDimDisplayName = PickWaveHelpers.GetEnumMemberAttributes<PickslipDimension, DisplayAttribute>()[pdimCol].Name;
            model.RowDimVal = string.IsNullOrEmpty(model.RowDimVal) ? RowDimensionModel.NULL_DIMENSION_VALUE : model.RowDimVal;
            model.CustomerName = (_service.GetCustomer(model.CustomerId) == null ? "" : _service.GetCustomer(model.CustomerId).Name);
            var bucket = _service.GetBucket(model.BucketId);
            model.Bucket = new BucketModel(bucket);
            return View(Views.PickslipList, model);
        }

        /// <summary>
        /// Add passed pickslips to passed bucket.
        /// </summary>
        /// <param name="model"> </param>
        /// <returns></returns>
        [HttpPost]
        public virtual ActionResult AddPickslipsToBucket(PickslipListViewModel model)
        {
            if (model.BucketId == 0)
            {
                throw new ArgumentNullException("model.BucketId");
            }
            if (model.SelectedPickslip != null)
            {
                _service.AddPickslipsToWave(model.BucketId, model.SelectedPickslip);
                AddStatusMessage(string.Format("{0} pickslips have been added to PickWave {1}", model.SelectedPickslip.Count, model.BucketId));
            }
            return RedirectToAction(this.Actions.PickslipList(model));
        }

        protected override string ManagerRoleName
        {
            get
            {
                return ROLE_WAVE_MANAGER;
            }
        }
    }
}
