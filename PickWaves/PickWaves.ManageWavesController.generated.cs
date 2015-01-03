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
namespace DcmsMobile.PickWaves.Areas.PickWaves.ManageWaves
{
    public partial class ManageWavesController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ManageWavesController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult WaveSkus()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveSkus);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult WaveBoxes()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveBoxes);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult FreezeBucket()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FreezeBucket);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult WavePickslips()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WavePickslips);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult FreezeAndEditBucket()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FreezeAndEditBucket);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UnfreezeBucket()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UnfreezeBucket);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult WaveEditor()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveEditor);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateWave()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateWave);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult IncrementPriority()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IncrementPriority);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DecrementPriority()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DecrementPriority);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RemovePickslipFromBucket()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemovePickslipFromBucket);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CancelBoxes()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CancelBoxes);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ManageWavesController Actions { get { return MVC_PickWaves.PickWaves.ManageWaves; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "PickWaves";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "ManageWaves";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "ManageWaves";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string WaveSkus = "WaveSkus";
            public readonly string WaveBoxes = "WaveBoxes";
            public readonly string FreezeBucket = "FreezeBucket";
            public readonly string WavePickslips = "WavePickslips";
            public readonly string FreezeAndEditBucket = "FreezeAndEditBucket";
            public readonly string UnfreezeBucket = "UnfreezeBucket";
            public readonly string WaveEditor = "WaveEditor";
            public readonly string UpdateWave = "UpdateWave";
            public readonly string IncrementPriority = "IncrementPriority";
            public readonly string DecrementPriority = "DecrementPriority";
            public readonly string RemovePickslipFromBucket = "RemovePickslipFromBucket";
            public readonly string CancelBoxes = "CancelBoxes";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string WaveSkus = "WaveSkus";
            public const string WaveBoxes = "WaveBoxes";
            public const string FreezeBucket = "FreezeBucket";
            public const string WavePickslips = "WavePickslips";
            public const string FreezeAndEditBucket = "FreezeAndEditBucket";
            public const string UnfreezeBucket = "UnfreezeBucket";
            public const string WaveEditor = "WaveEditor";
            public const string UpdateWave = "UpdateWave";
            public const string IncrementPriority = "IncrementPriority";
            public const string DecrementPriority = "DecrementPriority";
            public const string RemovePickslipFromBucket = "RemovePickslipFromBucket";
            public const string CancelBoxes = "CancelBoxes";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string customerId = "customerId";
            public readonly string userName = "userName";
            public readonly string bucketState = "bucketState";
        }
        static readonly ActionParamsClass_WaveSkus s_params_WaveSkus = new ActionParamsClass_WaveSkus();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_WaveSkus WaveSkusParams { get { return s_params_WaveSkus; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_WaveSkus
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_WaveBoxes s_params_WaveBoxes = new ActionParamsClass_WaveBoxes();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_WaveBoxes WaveBoxesParams { get { return s_params_WaveBoxes; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_WaveBoxes
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_FreezeBucket s_params_FreezeBucket = new ActionParamsClass_FreezeBucket();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_FreezeBucket FreezeBucketParams { get { return s_params_FreezeBucket; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_FreezeBucket
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_WavePickslips s_params_WavePickslips = new ActionParamsClass_WavePickslips();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_WavePickslips WavePickslipsParams { get { return s_params_WavePickslips; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_WavePickslips
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_FreezeAndEditBucket s_params_FreezeAndEditBucket = new ActionParamsClass_FreezeAndEditBucket();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_FreezeAndEditBucket FreezeAndEditBucketParams { get { return s_params_FreezeAndEditBucket; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_FreezeAndEditBucket
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_UnfreezeBucket s_params_UnfreezeBucket = new ActionParamsClass_UnfreezeBucket();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UnfreezeBucket UnfreezeBucketParams { get { return s_params_UnfreezeBucket; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UnfreezeBucket
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_WaveEditor s_params_WaveEditor = new ActionParamsClass_WaveEditor();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_WaveEditor WaveEditorParams { get { return s_params_WaveEditor; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_WaveEditor
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_UpdateWave s_params_UpdateWave = new ActionParamsClass_UpdateWave();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateWave UpdateWaveParams { get { return s_params_UpdateWave; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateWave
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_IncrementPriority s_params_IncrementPriority = new ActionParamsClass_IncrementPriority();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_IncrementPriority IncrementPriorityParams { get { return s_params_IncrementPriority; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_IncrementPriority
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_DecrementPriority s_params_DecrementPriority = new ActionParamsClass_DecrementPriority();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DecrementPriority DecrementPriorityParams { get { return s_params_DecrementPriority; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DecrementPriority
        {
            public readonly string bucketId = "bucketId";
        }
        static readonly ActionParamsClass_RemovePickslipFromBucket s_params_RemovePickslipFromBucket = new ActionParamsClass_RemovePickslipFromBucket();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RemovePickslipFromBucket RemovePickslipFromBucketParams { get { return s_params_RemovePickslipFromBucket; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RemovePickslipFromBucket
        {
            public readonly string bucketId = "bucketId";
            public readonly string pickslipId = "pickslipId";
        }
        static readonly ActionParamsClass_CancelBoxes s_params_CancelBoxes = new ActionParamsClass_CancelBoxes();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CancelBoxes CancelBoxesParams { get { return s_params_CancelBoxes; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CancelBoxes
        {
            public readonly string bucketId = "bucketId";
            public readonly string boxes = "boxes";
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
                public readonly string _waveBoxesPartial = "_waveBoxesPartial";
                public readonly string _waveSkusPartial = "_waveSkusPartial";
                public readonly string Index = "Index";
                public readonly string WaveBox = "WaveBox";
                public readonly string WaveEditor = "WaveEditor";
                public readonly string WavePickslips = "WavePickslips";
            }
            public readonly string _waveBoxesPartial = "~/Areas/PickWaves/ManageWaves/_waveBoxesPartial.cshtml";
            public readonly string _waveSkusPartial = "~/Areas/PickWaves/ManageWaves/_waveSkusPartial.cshtml";
            public readonly string Index = "~/Areas/PickWaves/ManageWaves/Index.cshtml";
            public readonly string WaveBox = "~/Areas/PickWaves/ManageWaves/WaveBox.cshtml";
            public readonly string WaveEditor = "~/Areas/PickWaves/ManageWaves/WaveEditor.cshtml";
            public readonly string WavePickslips = "~/Areas/PickWaves/ManageWaves/WavePickslips.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ManageWavesController : DcmsMobile.PickWaves.Areas.PickWaves.ManageWaves.ManageWavesController
    {
        public T4MVC_ManageWavesController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string customerId, string userName, DcmsMobile.PickWaves.Helpers.ProgressStage? bucketState);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(string customerId, string userName, DcmsMobile.PickWaves.Helpers.ProgressStage? bucketState)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "customerId", customerId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userName", userName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketState", bucketState);
            IndexOverride(callInfo, customerId, userName, bucketState);
            return callInfo;
        }

        [NonAction]
        partial void WaveSkusOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult WaveSkus(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveSkus);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            WaveSkusOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void WaveBoxesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult WaveBoxes(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveBoxes);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            WaveBoxesOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void FreezeBucketOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult FreezeBucket(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FreezeBucket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            FreezeBucketOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void WavePickslipsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult WavePickslips(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WavePickslips);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            WavePickslipsOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void FreezeAndEditBucketOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult FreezeAndEditBucket(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FreezeAndEditBucket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            FreezeAndEditBucketOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void UnfreezeBucketOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult UnfreezeBucket(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UnfreezeBucket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            UnfreezeBucketOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void WaveEditorOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult WaveEditor(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.WaveEditor);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            WaveEditorOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void UpdateWaveOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.PickWaves.Areas.PickWaves.ManageWaves.WaveEditorViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateWave(DcmsMobile.PickWaves.Areas.PickWaves.ManageWaves.WaveEditorViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateWave);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            UpdateWaveOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void IncrementPriorityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult IncrementPriority(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.IncrementPriority);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            IncrementPriorityOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void DecrementPriorityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId);

        [NonAction]
        public override System.Web.Mvc.ActionResult DecrementPriority(int bucketId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DecrementPriority);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            DecrementPriorityOverride(callInfo, bucketId);
            return callInfo;
        }

        [NonAction]
        partial void RemovePickslipFromBucketOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId, long pickslipId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RemovePickslipFromBucket(int bucketId, long pickslipId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemovePickslipFromBucket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pickslipId", pickslipId);
            RemovePickslipFromBucketOverride(callInfo, bucketId, pickslipId);
            return callInfo;
        }

        [NonAction]
        partial void CancelBoxesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int bucketId, string[] boxes);

        [NonAction]
        public override System.Web.Mvc.ActionResult CancelBoxes(int bucketId, string[] boxes)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CancelBoxes);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "bucketId", bucketId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "boxes", boxes);
            CancelBoxesOverride(callInfo, bucketId, boxes);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
