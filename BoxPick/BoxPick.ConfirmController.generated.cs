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
namespace DcmsMobile.BoxPick.Areas.BoxPick.Controllers
{
    public partial class ConfirmController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ConfirmController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ConfirmController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult PartialPickPallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PartialPickPallet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PartialPickPalletConfirm()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PartialPickPalletConfirm);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult StartSkipUcc()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.StartSkipUcc);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SkipUcc()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkipUcc);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ADRPallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ADRPallet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ConfirmADRPallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ConfirmADRPallet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SuspenseCarton()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SuspenseCarton);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ConfirmSuspenseCarton()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ConfirmSuspenseCarton);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Print()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Print);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PrintPallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PrintPallet);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ConfirmController Actions { get { return MVC_BoxPick.BoxPick.Confirm; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "BoxPick";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Confirm";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Confirm";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string PartialPickPallet = "PartialPickPallet";
            public readonly string PartialPickPalletConfirm = "PartialPickPallet";
            public readonly string StartSkipUcc = "SkipUcc";
            public readonly string SkipUcc = "SkipUcc";
            public readonly string ADRPallet = "ADRPallet";
            public readonly string ConfirmADRPallet = "ADRPallet";
            public readonly string SuspenseCarton = "ConfirmSuspenseCarton";
            public readonly string ConfirmSuspenseCarton = "ConfirmSuspenseCarton";
            public readonly string Print = "Print";
            public readonly string PrintPallet = "Print";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string PartialPickPallet = "PartialPickPallet";
            public const string PartialPickPalletConfirm = "PartialPickPallet";
            public const string StartSkipUcc = "SkipUcc";
            public const string SkipUcc = "SkipUcc";
            public const string ADRPallet = "ADRPallet";
            public const string ConfirmADRPallet = "ADRPallet";
            public const string SuspenseCarton = "ConfirmSuspenseCarton";
            public const string ConfirmSuspenseCarton = "ConfirmSuspenseCarton";
            public const string Print = "Print";
            public const string PrintPallet = "Print";
        }


        static readonly ActionParamsClass_PartialPickPallet s_params_PartialPickPallet = new ActionParamsClass_PartialPickPallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PartialPickPallet PartialPickPalletParams { get { return s_params_PartialPickPallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PartialPickPallet
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_PartialPickPalletConfirm s_params_PartialPickPalletConfirm = new ActionParamsClass_PartialPickPalletConfirm();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PartialPickPalletConfirm PartialPickPalletConfirmParams { get { return s_params_PartialPickPalletConfirm; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PartialPickPalletConfirm
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_StartSkipUcc s_params_StartSkipUcc = new ActionParamsClass_StartSkipUcc();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_StartSkipUcc StartSkipUccParams { get { return s_params_StartSkipUcc; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_StartSkipUcc
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_SkipUcc s_params_SkipUcc = new ActionParamsClass_SkipUcc();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SkipUcc SkipUccParams { get { return s_params_SkipUcc; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SkipUcc
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_ADRPallet s_params_ADRPallet = new ActionParamsClass_ADRPallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ADRPallet ADRPalletParams { get { return s_params_ADRPallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ADRPallet
        {
            public readonly string palletId = "palletId";
        }
        static readonly ActionParamsClass_ConfirmADRPallet s_params_ConfirmADRPallet = new ActionParamsClass_ConfirmADRPallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ConfirmADRPallet ConfirmADRPalletParams { get { return s_params_ConfirmADRPallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ConfirmADRPallet
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_SuspenseCarton s_params_SuspenseCarton = new ActionParamsClass_SuspenseCarton();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SuspenseCarton SuspenseCartonParams { get { return s_params_SuspenseCarton; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SuspenseCarton
        {
            public readonly string scannedCartonId = "scannedCartonId";
        }
        static readonly ActionParamsClass_ConfirmSuspenseCarton s_params_ConfirmSuspenseCarton = new ActionParamsClass_ConfirmSuspenseCarton();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ConfirmSuspenseCarton ConfirmSuspenseCartonParams { get { return s_params_ConfirmSuspenseCarton; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ConfirmSuspenseCarton
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Print s_params_Print = new ActionParamsClass_Print();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Print PrintParams { get { return s_params_Print; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Print
        {
            public readonly string palletId = "palletId";
        }
        static readonly ActionParamsClass_PrintPallet s_params_PrintPallet = new ActionParamsClass_PrintPallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PrintPallet PrintPalletParams { get { return s_params_PrintPallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PrintPallet
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
                public readonly string ADRPallet = "ADRPallet";
                public readonly string ConfirmSuspenseCarton = "ConfirmSuspenseCarton";
                public readonly string PartialPickPallet = "PartialPickPallet";
                public readonly string Print = "Print";
                public readonly string SkipUcc = "SkipUcc";
            }
            public readonly string ADRPallet = "~/Areas/BoxPick/Views/Confirm/ADRPallet.cshtml";
            public readonly string ConfirmSuspenseCarton = "~/Areas/BoxPick/Views/Confirm/ConfirmSuspenseCarton.cshtml";
            public readonly string PartialPickPallet = "~/Areas/BoxPick/Views/Confirm/PartialPickPallet.cshtml";
            public readonly string Print = "~/Areas/BoxPick/Views/Confirm/Print.cshtml";
            public readonly string SkipUcc = "~/Areas/BoxPick/Views/Confirm/SkipUcc.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ConfirmController : DcmsMobile.BoxPick.Areas.BoxPick.Controllers.ConfirmController
    {
        public T4MVC_ConfirmController() : base(Dummy.Instance) { }

        [NonAction]
        partial void PartialPickPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxPick.ViewModels.MasterModelWithPallet model);

        [NonAction]
        public override System.Web.Mvc.ActionResult PartialPickPallet(DcmsMobile.BoxPick.ViewModels.MasterModelWithPallet model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PartialPickPallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            PartialPickPalletOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void PartialPickPalletConfirmOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxPick.ViewModels.PartialPickPalletViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult PartialPickPalletConfirm(DcmsMobile.BoxPick.ViewModels.PartialPickPalletViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PartialPickPalletConfirm);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            PartialPickPalletConfirmOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void StartSkipUccOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxPick.ViewModels.MasterModelWithPallet model);

        [NonAction]
        public override System.Web.Mvc.ActionResult StartSkipUcc(DcmsMobile.BoxPick.ViewModels.MasterModelWithPallet model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.StartSkipUcc);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            StartSkipUccOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void SkipUccOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxPick.ViewModels.SkipUccViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult SkipUcc(DcmsMobile.BoxPick.ViewModels.SkipUccViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkipUcc);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SkipUccOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void ADRPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string palletId);

        [NonAction]
        public override System.Web.Mvc.ActionResult ADRPallet(string palletId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ADRPallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "palletId", palletId);
            ADRPalletOverride(callInfo, palletId);
            return callInfo;
        }

        [NonAction]
        partial void ConfirmADRPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxPick.ViewModels.ADRPalletViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult ConfirmADRPallet(DcmsMobile.BoxPick.ViewModels.ADRPalletViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ConfirmADRPallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ConfirmADRPalletOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void SuspenseCartonOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string scannedCartonId);

        [NonAction]
        public override System.Web.Mvc.ActionResult SuspenseCarton(string scannedCartonId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SuspenseCarton);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "scannedCartonId", scannedCartonId);
            SuspenseCartonOverride(callInfo, scannedCartonId);
            return callInfo;
        }

        [NonAction]
        partial void ConfirmSuspenseCartonOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxPick.ViewModels.CartonViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult ConfirmSuspenseCarton(DcmsMobile.BoxPick.ViewModels.CartonViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ConfirmSuspenseCarton);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ConfirmSuspenseCartonOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void PrintOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string palletId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Print(string palletId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Print);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "palletId", palletId);
            PrintOverride(callInfo, palletId);
            return callInfo;
        }

        [NonAction]
        partial void PrintPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.BoxPick.ViewModels.PrinterViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult PrintPallet(DcmsMobile.BoxPick.ViewModels.PrinterViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PrintPallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            PrintPalletOverride(callInfo, model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
