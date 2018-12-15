// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
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
namespace DcmsMobile.CartonManager.Areas.CartonManager.Controllers
{
    public partial class LocatingController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LocatingController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected LocatingController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult CartonLocating()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonLocating);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AcceptPallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AcceptPallet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult HandleScan()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandleScan);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LocatingController Actions { get { return MVC_CartonManager.CartonManager.Locating; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "CartonManager";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Locating";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Locating";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Pallet = "Pallet";
            public readonly string CartonLocating = "CartonLocating";
            public readonly string AcceptPallet = "AcceptPallet";
            public readonly string HandleScan = "HandleScan";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Pallet = "Pallet";
            public const string CartonLocating = "CartonLocating";
            public const string AcceptPallet = "AcceptPallet";
            public const string HandleScan = "HandleScan";
        }


        static readonly ActionParamsClass_Pallet s_params_Pallet = new ActionParamsClass_Pallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Pallet PalletParams { get { return s_params_Pallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Pallet
        {
            public readonly string sound = "sound";
        }
        static readonly ActionParamsClass_CartonLocating s_params_CartonLocating = new ActionParamsClass_CartonLocating();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CartonLocating CartonLocatingParams { get { return s_params_CartonLocating; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CartonLocating
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_AcceptPallet s_params_AcceptPallet = new ActionParamsClass_AcceptPallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AcceptPallet AcceptPalletParams { get { return s_params_AcceptPallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AcceptPallet
        {
            public readonly string palletId = "palletId";
        }
        static readonly ActionParamsClass_HandleScan s_params_HandleScan = new ActionParamsClass_HandleScan();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_HandleScan HandleScanParams { get { return s_params_HandleScan; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_HandleScan
        {
            public readonly string model = "model";
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
                public readonly string LocationCarton = "LocationCarton";
                public readonly string Pallet = "Pallet";
            }
            public readonly string LocationCarton = "~/Areas/CartonManager/Views/Locating/LocationCarton.cshtml";
            public readonly string Pallet = "~/Areas/CartonManager/Views/Locating/Pallet.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_LocatingController : DcmsMobile.CartonManager.Areas.CartonManager.Controllers.LocatingController
    {
        public T4MVC_LocatingController() : base(Dummy.Instance) { }

        [NonAction]
        partial void PalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.CartonManager.Repository.Locating.Sound sound);

        [NonAction]
        public override System.Web.Mvc.ActionResult Pallet(DcmsMobile.CartonManager.Repository.Locating.Sound sound)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Pallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sound", sound);
            PalletOverride(callInfo, sound);
            return callInfo;
        }

        [NonAction]
        partial void CartonLocatingOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult CartonLocating(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonLocating);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CartonLocatingOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void AcceptPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string palletId);

        [NonAction]
        public override System.Web.Mvc.ActionResult AcceptPallet(string palletId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AcceptPallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "palletId", palletId);
            AcceptPalletOverride(callInfo, palletId);
            return callInfo;
        }

        [NonAction]
        partial void HandleScanOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.CartonManager.ViewModels.Locating.LocationCartonViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult HandleScan(DcmsMobile.CartonManager.ViewModels.Locating.LocationCartonViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandleScan);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            HandleScanOverride(callInfo, model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
