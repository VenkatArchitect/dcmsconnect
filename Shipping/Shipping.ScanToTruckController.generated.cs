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
namespace DcmsMobile.Shipping.Areas.Shipping.Controllers
{
    public partial class ScanToTruckController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ScanToTruckController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult LoadTruck()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LoadTruck);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Appointment()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Appointment);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Pallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Pallet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UnloadPallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UnloadPallet);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ScanToTruckController Actions { get { return MVC_Shipping.Shipping.ScanToTruck; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Shipping";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "ScanToTruck";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "ScanToTruck";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string LoadTruck = "LoadTruck";
            public readonly string Appointment = "Appointment";
            public readonly string Pallet = "Pallet";
            public readonly string UnloadPallet = "UnloadPallet";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string LoadTruck = "LoadTruck";
            public const string Appointment = "Appointment";
            public const string Pallet = "Pallet";
            public const string UnloadPallet = "UnloadPallet";
        }


        static readonly ActionParamsClass_LoadTruck s_params_LoadTruck = new ActionParamsClass_LoadTruck();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_LoadTruck LoadTruckParams { get { return s_params_LoadTruck; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_LoadTruck
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Appointment s_params_Appointment = new ActionParamsClass_Appointment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Appointment AppointmentParams { get { return s_params_Appointment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Appointment
        {
            public readonly string ivm = "ivm";
        }
        static readonly ActionParamsClass_Pallet s_params_Pallet = new ActionParamsClass_Pallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Pallet PalletParams { get { return s_params_Pallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Pallet
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_UnloadPallet s_params_UnloadPallet = new ActionParamsClass_UnloadPallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UnloadPallet UnloadPalletParams { get { return s_params_UnloadPallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UnloadPallet
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
                public readonly string Index = "Index";
                public readonly string Pallet = "Pallet";
                public readonly string UnloadPallet = "UnloadPallet";
            }
            public readonly string Index = "~/Areas/Shipping/ScanToTruck/Index.cshtml";
            public readonly string Pallet = "~/Areas/Shipping/ScanToTruck/Pallet.cshtml";
            public readonly string UnloadPallet = "~/Areas/Shipping/ScanToTruck/UnloadPallet.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ScanToTruckController : DcmsMobile.Shipping.Areas.Shipping.Controllers.ScanToTruckController
    {
        public T4MVC_ScanToTruckController() : base(Dummy.Instance) { }

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
        partial void LoadTruckOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? id);

        [NonAction]
        public override System.Web.Mvc.ActionResult LoadTruck(int? id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LoadTruck);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            LoadTruckOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void AppointmentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.Shipping.ViewModels.ScanToTruck.IndexViewModel ivm);

        [NonAction]
        public override System.Web.Mvc.ActionResult Appointment(DcmsMobile.Shipping.ViewModels.ScanToTruck.IndexViewModel ivm)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Appointment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ivm", ivm);
            AppointmentOverride(callInfo, ivm);
            return callInfo;
        }

        [NonAction]
        partial void PalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.Shipping.ViewModels.ScanToTruck.PalletViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult Pallet(DcmsMobile.Shipping.ViewModels.ScanToTruck.PalletViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Pallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            PalletOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void UnloadPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.Shipping.ViewModels.ScanToTruck.UnloadPalletViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult UnloadPallet(DcmsMobile.Shipping.ViewModels.ScanToTruck.UnloadPalletViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UnloadPallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            UnloadPalletOverride(callInfo, model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
