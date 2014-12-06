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
namespace DcmsMobile.Inquiry.Areas.Inquiry.CartonEntity
{
    public partial class CartonEntityController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CartonEntityController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CartonEntityController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Carton()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Carton);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PrintCartonTicket()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PrintCartonTicket);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CartonExcel()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonExcel);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CartonOpen()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonOpen);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CartonIntransit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonIntransit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CartonPallet()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonPallet);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CartonPalletExcel()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonPalletExcel);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CartonEntityController Actions { get { return MVC_Inquiry.Inquiry.CartonEntity; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Inquiry";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "CartonEntity";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "CartonEntity";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Carton = "Carton";
            public readonly string PrintCartonTicket = "PrintCartonTicket";
            public readonly string CartonExcel = "CartonExcel";
            public readonly string CartonOpen = "CartonOpen";
            public readonly string CartonIntransit = "CartonIntransit";
            public readonly string CartonPallet = "CartonPallet";
            public readonly string CartonPalletExcel = "CartonPalletExcel";
            public readonly string CartonList = "CartonList";
            public readonly string PalletList = "PalletList";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Carton = "Carton";
            public const string PrintCartonTicket = "PrintCartonTicket";
            public const string CartonExcel = "CartonExcel";
            public const string CartonOpen = "CartonOpen";
            public const string CartonIntransit = "CartonIntransit";
            public const string CartonPallet = "CartonPallet";
            public const string CartonPalletExcel = "CartonPalletExcel";
            public const string CartonList = "CartonList";
            public const string PalletList = "PalletList";
        }


        static readonly ActionParamsClass_Carton s_params_Carton = new ActionParamsClass_Carton();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Carton CartonParams { get { return s_params_Carton; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Carton
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_PrintCartonTicket s_params_PrintCartonTicket = new ActionParamsClass_PrintCartonTicket();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PrintCartonTicket PrintCartonTicketParams { get { return s_params_PrintCartonTicket; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PrintCartonTicket
        {
            public readonly string cartonId = "cartonId";
            public readonly string printerId = "printerId";
        }
        static readonly ActionParamsClass_CartonExcel s_params_CartonExcel = new ActionParamsClass_CartonExcel();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CartonExcel CartonExcelParams { get { return s_params_CartonExcel; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CartonExcel
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_CartonOpen s_params_CartonOpen = new ActionParamsClass_CartonOpen();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CartonOpen CartonOpenParams { get { return s_params_CartonOpen; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CartonOpen
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_CartonIntransit s_params_CartonIntransit = new ActionParamsClass_CartonIntransit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CartonIntransit CartonIntransitParams { get { return s_params_CartonIntransit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CartonIntransit
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_CartonPallet s_params_CartonPallet = new ActionParamsClass_CartonPallet();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CartonPallet CartonPalletParams { get { return s_params_CartonPallet; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CartonPallet
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_CartonPalletExcel s_params_CartonPalletExcel = new ActionParamsClass_CartonPalletExcel();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CartonPalletExcel CartonPalletExcelParams { get { return s_params_CartonPalletExcel; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CartonPalletExcel
        {
            public readonly string id = "id";
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
                public readonly string _cartonListPartial = "_cartonListPartial";
                public readonly string _cartonProcessPartial = "_cartonProcessPartial";
                public readonly string Carton = "Carton";
                public readonly string Carton_png = "Carton_png";
                public readonly string CartonIntransit = "CartonIntransit";
                public readonly string CartonList = "CartonList";
                public readonly string CartonOpen = "CartonOpen";
                public readonly string CartonPallet = "CartonPallet";
                public readonly string CartonPalletList = "CartonPalletList";
                public readonly string IntransitCarton = "IntransitCarton";
                public readonly string OpenCarton = "OpenCarton";
                public readonly string Pallet = "Pallet";
            }
            public readonly string _cartonListPartial = "~/Areas/Inquiry/CartonEntity/_cartonListPartial.cshtml";
            public readonly string _cartonProcessPartial = "~/Areas/Inquiry/CartonEntity/_cartonProcessPartial.cshtml";
            public readonly string Carton = "~/Areas/Inquiry/CartonEntity/Carton.cshtml";
            public readonly string Carton_png = "~/Areas/Inquiry/CartonEntity/Carton.png";
            public readonly string CartonIntransit = "~/Areas/Inquiry/CartonEntity/CartonIntransit.cshtml";
            public readonly string CartonList = "~/Areas/Inquiry/CartonEntity/CartonList.cshtml";
            public readonly string CartonOpen = "~/Areas/Inquiry/CartonEntity/CartonOpen.cshtml";
            public readonly string CartonPallet = "~/Areas/Inquiry/CartonEntity/CartonPallet.cshtml";
            public readonly string CartonPalletList = "~/Areas/Inquiry/CartonEntity/CartonPalletList.cshtml";
            public readonly string IntransitCarton = "~/Areas/Inquiry/CartonEntity/IntransitCarton.jpg";
            public readonly string OpenCarton = "~/Areas/Inquiry/CartonEntity/OpenCarton.jpg";
            public readonly string Pallet = "~/Areas/Inquiry/CartonEntity/Pallet.jpg";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CartonEntityController : DcmsMobile.Inquiry.Areas.Inquiry.CartonEntity.CartonEntityController
    {
        public T4MVC_CartonEntityController() : base(Dummy.Instance) { }

        [NonAction]
        partial void CartonOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Carton(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Carton);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CartonOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void PrintCartonTicketOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string cartonId, string printerId);

        [NonAction]
        public override System.Web.Mvc.ActionResult PrintCartonTicket(string cartonId, string printerId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PrintCartonTicket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cartonId", cartonId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "printerId", printerId);
            PrintCartonTicketOverride(callInfo, cartonId, printerId);
            return callInfo;
        }

        [NonAction]
        partial void CartonExcelOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult CartonExcel(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonExcel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CartonExcelOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CartonOpenOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult CartonOpen(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonOpen);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CartonOpenOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CartonIntransitOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult CartonIntransit(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonIntransit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CartonIntransitOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CartonPalletOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult CartonPallet(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonPallet);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CartonPalletOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CartonPalletExcelOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult CartonPalletExcel(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonPalletExcel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            CartonPalletExcelOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void CartonListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult CartonList()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CartonList);
            CartonListOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void PalletListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult PalletList()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PalletList);
            PalletListOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
