// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace DcmsMobile.REQ2.Areas.REQ2.Home
{
    public partial class HomeController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PullRequest()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PullRequest);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PropertyEditor()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PropertyEditor);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateRequest()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateRequest);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Search()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Search);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DeleteRequest()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteRequest);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SkuEditor()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuEditor);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CartonList()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonList);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddSku()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddSku);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DeleteSku()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteSku);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC_REQ2.REQ2.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "REQ2";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Home";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string PullRequest = "PullRequest";
            public readonly string PropertyEditor = "PropertyEditor";
            public readonly string Index = "Index";
            public readonly string UpdateRequest = "UpdateRequest";
            public readonly string Search = "Search";
            public readonly string DeleteRequest = "DeleteRequest";
            public readonly string SkuEditor = "SkuEditor";
            public readonly string CartonList = "CartonList";
            public readonly string AddSku = "AddSku";
            public readonly string DeleteSku = "DeleteSku";
            public readonly string AssignCartons = "AssignCartons";
            public readonly string UnAssignCartons = "UnAssignCartons";
            public readonly string Tutorial = "Tutorial";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string PullRequest = "PullRequest";
            public const string PropertyEditor = "PropertyEditor";
            public const string Index = "Index";
            public const string UpdateRequest = "UpdateRequest";
            public const string Search = "Search";
            public const string DeleteRequest = "DeleteRequest";
            public const string SkuEditor = "SkuEditor";
            public const string CartonList = "CartonList";
            public const string AddSku = "AddSku";
            public const string DeleteSku = "DeleteSku";
            public const string AssignCartons = "AssignCartons";
            public const string UnAssignCartons = "UnAssignCartons";
            public const string Tutorial = "Tutorial";
        }


        static readonly ActionParamsClass_PullRequest s_params_PullRequest = new ActionParamsClass_PullRequest();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PullRequest PullRequestParams { get { return s_params_PullRequest; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PullRequest
        {
            public readonly string ctnresvId = "ctnresvId";
        }
        static readonly ActionParamsClass_PropertyEditor s_params_PropertyEditor = new ActionParamsClass_PropertyEditor();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PropertyEditor PropertyEditorParams { get { return s_params_PropertyEditor; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PropertyEditor
        {
            public readonly string ctnresvId = "ctnresvId";
        }
        static readonly ActionParamsClass_UpdateRequest s_params_UpdateRequest = new ActionParamsClass_UpdateRequest();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateRequest UpdateRequestParams { get { return s_params_UpdateRequest; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateRequest
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Search s_params_Search = new ActionParamsClass_Search();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Search SearchParams { get { return s_params_Search; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Search
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_DeleteRequest s_params_DeleteRequest = new ActionParamsClass_DeleteRequest();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteRequest DeleteRequestParams { get { return s_params_DeleteRequest; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteRequest
        {
            public readonly string resvId = "resvId";
        }
        static readonly ActionParamsClass_SkuEditor s_params_SkuEditor = new ActionParamsClass_SkuEditor();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SkuEditor SkuEditorParams { get { return s_params_SkuEditor; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SkuEditor
        {
            public readonly string ctnresvId = "ctnresvId";
        }
        static readonly ActionParamsClass_CartonList s_params_CartonList = new ActionParamsClass_CartonList();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CartonList CartonListParams { get { return s_params_CartonList; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CartonList
        {
            public readonly string ctnresvId = "ctnresvId";
        }
        static readonly ActionParamsClass_AddSku s_params_AddSku = new ActionParamsClass_AddSku();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddSku AddSkuParams { get { return s_params_AddSku; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddSku
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_DeleteSku s_params_DeleteSku = new ActionParamsClass_DeleteSku();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteSku DeleteSkuParams { get { return s_params_DeleteSku; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteSku
        {
            public readonly string skuId = "skuId";
            public readonly string resvId = "resvId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _assignedCartonInfoPartial = "_assignedCartonInfoPartial";
                public readonly string _existingRequestPartial = "_existingRequestPartial";
                public readonly string _manageSkuListPartial = "_manageSkuListPartial";
                public readonly string CartonList = "CartonList";
                public readonly string Index = "Index";
                public readonly string PropertyEditor = "PropertyEditor";
                public readonly string PullRequest = "PullRequest";
                public readonly string SkuEditor = "SkuEditor";
                public readonly string Stylesheets_chirp = "Stylesheets.chirp";
                public readonly string Tutorial = "Tutorial";
            }
            public readonly string _assignedCartonInfoPartial = "~/Areas/REQ2/Home/_assignedCartonInfoPartial.cshtml";
            public readonly string _existingRequestPartial = "~/Areas/REQ2/Home/_existingRequestPartial.cshtml";
            public readonly string _manageSkuListPartial = "~/Areas/REQ2/Home/_manageSkuListPartial.cshtml";
            public readonly string CartonList = "~/Areas/REQ2/Home/CartonList.cshtml";
            public readonly string Index = "~/Areas/REQ2/Home/Index.cshtml";
            public readonly string PropertyEditor = "~/Areas/REQ2/Home/PropertyEditor.cshtml";
            public readonly string PullRequest = "~/Areas/REQ2/Home/PullRequest.cshtml";
            public readonly string SkuEditor = "~/Areas/REQ2/Home/SkuEditor.cshtml";
            public readonly string Stylesheets_chirp = "~/Areas/REQ2/Home/Stylesheets.chirp.config";
            public readonly string Tutorial = "~/Areas/REQ2/Home/Tutorial.cshtml";
            static readonly _imagesClass s_images = new _imagesClass();
            public _imagesClass images { get { return s_images; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _imagesClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string a1 = "a1";
                    public readonly string ajax_loader = "ajax-loader";
                    public readonly string calendar = "calendar";
                }
                public readonly string a1 = "~/Areas/REQ2/Home/images/a1.gif";
                public readonly string ajax_loader = "~/Areas/REQ2/Home/images/ajax-loader.gif";
                public readonly string calendar = "~/Areas/REQ2/Home/images/calendar.gif";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : DcmsMobile.REQ2.Areas.REQ2.Home.HomeController
    {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

        [NonAction]
        partial void PullRequestOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ctnresvId);

        [NonAction]
        public override System.Web.Mvc.ActionResult PullRequest(string ctnresvId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PullRequest);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ctnresvId", ctnresvId);
            PullRequestOverride(callInfo, ctnresvId);
            return callInfo;
        }

        [NonAction]
        partial void PropertyEditorOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ctnresvId);

        [NonAction]
        public override System.Web.Mvc.ActionResult PropertyEditor(string ctnresvId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PropertyEditor);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ctnresvId", ctnresvId);
            PropertyEditorOverride(callInfo, ctnresvId);
            return callInfo;
        }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void UpdateRequestOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.REQ2.Areas.REQ2.Home.PropertyEditorViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateRequest(DcmsMobile.REQ2.Areas.REQ2.Home.PropertyEditorViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateRequest);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            UpdateRequestOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void SearchOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Search(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Search);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            SearchOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void DeleteRequestOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string resvId);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeleteRequest(string resvId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteRequest);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "resvId", resvId);
            DeleteRequestOverride(callInfo, resvId);
            return callInfo;
        }

        [NonAction]
        partial void SkuEditorOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ctnresvId);

        [NonAction]
        public override System.Web.Mvc.ActionResult SkuEditor(string ctnresvId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuEditor);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ctnresvId", ctnresvId);
            SkuEditorOverride(callInfo, ctnresvId);
            return callInfo;
        }

        [NonAction]
        partial void CartonListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ctnresvId);

        [NonAction]
        public override System.Web.Mvc.ActionResult CartonList(string ctnresvId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ctnresvId", ctnresvId);
            CartonListOverride(callInfo, ctnresvId);
            return callInfo;
        }

        [NonAction]
        partial void AddSkuOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.REQ2.Areas.REQ2.Home.ManageSkuViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddSku(DcmsMobile.REQ2.Areas.REQ2.Home.ManageSkuViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddSku);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            AddSkuOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void DeleteSkuOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? skuId, string resvId);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeleteSku(int? skuId, string resvId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteSku);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "skuId", skuId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "resvId", resvId);
            DeleteSkuOverride(callInfo, skuId, resvId);
            return callInfo;
        }

        [NonAction]
        partial void AssignCartonsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult AssignCartons()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AssignCartons);
            AssignCartonsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void UnAssignCartonsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult UnAssignCartons()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UnAssignCartons);
            UnAssignCartonsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void TutorialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Tutorial()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tutorial);
            TutorialOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
