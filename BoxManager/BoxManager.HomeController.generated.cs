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
namespace DcmsMobile.BoxManager.Areas.BoxManager.Controllers
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
        public virtual System.Web.Mvc.ActionResult ActivatePallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActivatePallet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ApplyVasToBox()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyVasToBox);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ScanToPallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ScanToPallet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult HandleScan()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandleScan);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Location()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Location);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult LocatePallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LocatePallet);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC_BoxManager.BoxManager.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "BoxManager";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string CreatingPalletIndex = "CreatingPalletIndex";
            public readonly string VasPallet = "VasPallet";
            public readonly string ActivatePallet = "ActivatePallet";
            public readonly string ApplyVasToBox = "ApplyVasToBox";
            public readonly string ScanToPallet = "ScanToPallet";
            public readonly string HandleScan = "HandleScan";
            public readonly string Location = "Location";
            public readonly string LocatePallet = "LocatePallet";
            public readonly string Tutorial = "Tutorial";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string CreatingPalletIndex = "CreatingPalletIndex";
            public const string VasPallet = "VasPallet";
            public const string ActivatePallet = "ActivatePallet";
            public const string ApplyVasToBox = "ApplyVasToBox";
            public const string ScanToPallet = "ScanToPallet";
            public const string HandleScan = "HandleScan";
            public const string Location = "Location";
            public const string LocatePallet = "LocatePallet";
            public const string Tutorial = "Tutorial";
        }


        static readonly ActionParamsClass_ActivatePallet s_params_ActivatePallet = new ActionParamsClass_ActivatePallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActivatePallet ActivatePalletParams { get { return s_params_ActivatePallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActivatePallet
        {
            public readonly string palletId = "palletId";
            public readonly string lastScanText = "lastScanText";
            public readonly string sound = "sound";
            public readonly string confirmPalletScan = "confirmPalletScan";
        }
        static readonly ActionParamsClass_ApplyVasToBox s_params_ApplyVasToBox = new ActionParamsClass_ApplyVasToBox();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ApplyVasToBox ApplyVasToBoxParams { get { return s_params_ApplyVasToBox; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ApplyVasToBox
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_ScanToPallet s_params_ScanToPallet = new ActionParamsClass_ScanToPallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ScanToPallet ScanToPalletParams { get { return s_params_ScanToPallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ScanToPallet
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_HandleScan s_params_HandleScan = new ActionParamsClass_HandleScan();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_HandleScan HandleScanParams { get { return s_params_HandleScan; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_HandleScan
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Location s_params_Location = new ActionParamsClass_Location();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Location LocationParams { get { return s_params_Location; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Location
        {
            public readonly string palletId = "palletId";
        }
        static readonly ActionParamsClass_LocatePallet s_params_LocatePallet = new ActionParamsClass_LocatePallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_LocatePallet LocatePalletParams { get { return s_params_LocatePallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_LocatePallet
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
                public readonly string _palletPartial = "_palletPartial";
                public readonly string Index = "Index";
                public readonly string Index_mobile = "Index.mobile";
                public readonly string Location = "Location";
                public readonly string ScanToPallet = "ScanToPallet";
                public readonly string Tutorial = "Tutorial";
            }
            public readonly string _palletPartial = "~/Areas/BoxManager/Views/Home/_palletPartial.cshtml";
            public readonly string Index = "~/Areas/BoxManager/Views/Home/Index.cshtml";
            public readonly string Index_mobile = "~/Areas/BoxManager/Views/Home/Index.mobile.cshtml";
            public readonly string Location = "~/Areas/BoxManager/Views/Home/Location.cshtml";
            public readonly string ScanToPallet = "~/Areas/BoxManager/Views/Home/ScanToPallet.cshtml";
            public readonly string Tutorial = "~/Areas/BoxManager/Views/Home/Tutorial.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : DcmsMobile.BoxManager.Areas.BoxManager.Controllers.HomeController
    {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

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
        partial void CreatingPalletIndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreatingPalletIndex()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreatingPalletIndex);
            CreatingPalletIndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void VasPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult VasPallet()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VasPallet);
            VasPalletOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ActivatePalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string palletId, string lastScanText, DcmsMobile.BoxManager.Repository.Sound sound, string confirmPalletScan);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActivatePallet(string palletId, string lastScanText, DcmsMobile.BoxManager.Repository.Sound sound, string confirmPalletScan)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActivatePallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "palletId", palletId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "lastScanText", lastScanText);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sound", sound);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "confirmPalletScan", confirmPalletScan);
            ActivatePalletOverride(callInfo, palletId, lastScanText, sound, confirmPalletScan);
            return callInfo;
        }

        [NonAction]
        partial void ApplyVasToBoxOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult ApplyVasToBox(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyVasToBox);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ApplyVasToBoxOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void ScanToPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult ScanToPallet(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ScanToPallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ScanToPalletOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void HandleScanOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxManager.ViewModels.Home.ScanToPalletViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult HandleScan(DcmsMobile.BoxManager.ViewModels.Home.ScanToPalletViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandleScan);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            HandleScanOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void LocationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string palletId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Location(string palletId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Location);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "palletId", palletId);
            LocationOverride(callInfo, palletId);
            return callInfo;
        }

        [NonAction]
        partial void LocatePalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxManager.ViewModels.Home.LocationViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult LocatePallet(DcmsMobile.BoxManager.ViewModels.Home.LocationViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LocatePallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            LocatePalletOverride(callInfo, model);
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
#pragma warning restore 1591, 3008, 3009, 0108, 0114
