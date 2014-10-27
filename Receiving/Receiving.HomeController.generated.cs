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
namespace DcmsMobile.Receiving.Areas.Receiving.Controllers
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
        public virtual System.Web.Mvc.ActionResult CreateProcess()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateProcess);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EditProcess()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditProcess);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Receiving()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Receiving);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Tutorial()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tutorial);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult HandlePalletScan()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandlePalletScan);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult HandleMobileScan()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandleMobileScan);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UnPalletizeCarton()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UnPalletizeCarton);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PrintCarton()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PrintCarton);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult NonpalletizedCartons()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.NonpalletizedCartons);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult CloseShipment()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CloseShipment);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ReOpenShipment()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ReOpenShipment);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC_Receiving.Receiving.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Receiving";
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
            public readonly string Index = "Index";
            public readonly string CreateProcess = "CreateProcess";
            public readonly string EditProcess = "EditProcess";
            public readonly string Receiving = "Receiving";
            public readonly string Tutorial = "Tutorial";
            public readonly string HandlePalletScan = "HandlePalletScan";
            public readonly string HandleMobileScan = "HandleScan";
            public readonly string UnPalletizeCarton = "UnPalletizeCarton";
            public readonly string PrintCarton = "PrintCarton";
            public readonly string GetPrinters = "GetPrinters";
            public readonly string NonpalletizedCartons = "NonpalletizedCartons";
            public readonly string ShipmentList = "ShipmentList";
            public readonly string CloseShipment = "CloseShipment";
            public readonly string ReOpenShipment = "ReOpenShipment";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string CreateProcess = "CreateProcess";
            public const string EditProcess = "EditProcess";
            public const string Receiving = "Receiving";
            public const string Tutorial = "Tutorial";
            public const string HandlePalletScan = "HandlePalletScan";
            public const string HandleMobileScan = "HandleScan";
            public const string UnPalletizeCarton = "UnPalletizeCarton";
            public const string PrintCarton = "PrintCarton";
            public const string GetPrinters = "GetPrinters";
            public const string NonpalletizedCartons = "NonpalletizedCartons";
            public const string ShipmentList = "ShipmentList";
            public const string CloseShipment = "CloseShipment";
            public const string ReOpenShipment = "ReOpenShipment";
        }


        static readonly ActionParamsClass_CreateProcess s_params_CreateProcess = new ActionParamsClass_CreateProcess();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreateProcess CreateProcessParams { get { return s_params_CreateProcess; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreateProcess
        {
            public readonly string processId = "processId";
        }
        static readonly ActionParamsClass_EditProcess s_params_EditProcess = new ActionParamsClass_EditProcess();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditProcess EditProcessParams { get { return s_params_EditProcess; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditProcess
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_Receiving s_params_Receiving = new ActionParamsClass_Receiving();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Receiving ReceivingParams { get { return s_params_Receiving; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Receiving
        {
            public readonly string processId = "processId";
        }
        static readonly ActionParamsClass_Tutorial s_params_Tutorial = new ActionParamsClass_Tutorial();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Tutorial TutorialParams { get { return s_params_Tutorial; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Tutorial
        {
            public readonly string processId = "processId";
        }
        static readonly ActionParamsClass_HandlePalletScan s_params_HandlePalletScan = new ActionParamsClass_HandlePalletScan();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_HandlePalletScan HandlePalletScanParams { get { return s_params_HandlePalletScan; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_HandlePalletScan
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_HandleMobileScan s_params_HandleMobileScan = new ActionParamsClass_HandleMobileScan();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_HandleMobileScan HandleMobileScanParams { get { return s_params_HandleMobileScan; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_HandleMobileScan
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_UnPalletizeCarton s_params_UnPalletizeCarton = new ActionParamsClass_UnPalletizeCarton();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UnPalletizeCarton UnPalletizeCartonParams { get { return s_params_UnPalletizeCarton; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UnPalletizeCarton
        {
            public readonly string cartonId = "cartonId";
            public readonly string processId = "processId";
        }
        static readonly ActionParamsClass_PrintCarton s_params_PrintCarton = new ActionParamsClass_PrintCarton();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PrintCarton PrintCartonParams { get { return s_params_PrintCarton; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PrintCarton
        {
            public readonly string cartonId = "cartonId";
            public readonly string printer = "printer";
        }
        static readonly ActionParamsClass_NonpalletizedCartons s_params_NonpalletizedCartons = new ActionParamsClass_NonpalletizedCartons();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_NonpalletizedCartons NonpalletizedCartonsParams { get { return s_params_NonpalletizedCartons; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_NonpalletizedCartons
        {
            public readonly string processId = "processId";
        }
        static readonly ActionParamsClass_CloseShipment s_params_CloseShipment = new ActionParamsClass_CloseShipment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CloseShipment CloseShipmentParams { get { return s_params_CloseShipment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CloseShipment
        {
            public readonly string shipmentId = "shipmentId";
            public readonly string poId = "poId";
        }
        static readonly ActionParamsClass_ReOpenShipment s_params_ReOpenShipment = new ActionParamsClass_ReOpenShipment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ReOpenShipment ReOpenShipmentParams { get { return s_params_ReOpenShipment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ReOpenShipment
        {
            public readonly string shipmentId = "shipmentId";
            public readonly string poId = "poId";
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
                public readonly string _cartonNotOnPalletPartial = "_cartonNotOnPalletPartial";
                public readonly string _palletPartial = "_palletPartial";
                public readonly string _palletPartial_desktop = "_palletPartial.desktop";
                public readonly string CreateProcess = "CreateProcess";
                public readonly string Index = "Index";
                public readonly string Index_desktop = "Index.desktop";
                public readonly string Receiving = "Receiving";
                public readonly string Receiving_desktop = "Receiving.desktop";
                public readonly string Receiving_desktop1 = "Receiving.desktop1";
                public readonly string ShipmentList = "ShipmentList";
                public readonly string ShipmentList_desktop = "ShipmentList.desktop";
                public readonly string Tutorial = "Tutorial";
            }
            public readonly string _cartonNotOnPalletPartial = "~/Areas/Receiving/Views/Home/_cartonNotOnPalletPartial.cshtml";
            public readonly string _palletPartial = "~/Areas/Receiving/Views/Home/_palletPartial.cshtml";
            public readonly string _palletPartial_desktop = "~/Areas/Receiving/Views/Home/_palletPartial.desktop.cshtml";
            public readonly string CreateProcess = "~/Areas/Receiving/Views/Home/CreateProcess.cshtml";
            public readonly string Index = "~/Areas/Receiving/Views/Home/Index.cshtml";
            public readonly string Index_desktop = "~/Areas/Receiving/Views/Home/Index.desktop.cshtml";
            public readonly string Receiving = "~/Areas/Receiving/Views/Home/Receiving.cshtml";
            public readonly string Receiving_desktop = "~/Areas/Receiving/Views/Home/Receiving.desktop.cshtml";
            public readonly string Receiving_desktop1 = "~/Areas/Receiving/Views/Home/Receiving.desktop1.cshtml";
            public readonly string ShipmentList = "~/Areas/Receiving/Views/Home/ShipmentList.cshtml";
            public readonly string ShipmentList_desktop = "~/Areas/Receiving/Views/Home/ShipmentList.desktop.cshtml";
            public readonly string Tutorial = "~/Areas/Receiving/Views/Home/Tutorial.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : DcmsMobile.Receiving.Areas.Receiving.Controllers.HomeController
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
        partial void CreateProcessOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? processId);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreateProcess(int? processId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateProcess);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "processId", processId);
            CreateProcessOverride(callInfo, processId);
            return callInfo;
        }

        [NonAction]
        partial void EditProcessOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.Receiving.ViewModels.Home.ReceivingProcessModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult EditProcess(DcmsMobile.Receiving.ViewModels.Home.ReceivingProcessModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditProcess);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditProcessOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void ReceivingOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? processId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Receiving(int? processId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Receiving);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "processId", processId);
            ReceivingOverride(callInfo, processId);
            return callInfo;
        }

        [NonAction]
        partial void TutorialOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? processId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Tutorial(int? processId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tutorial);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "processId", processId);
            TutorialOverride(callInfo, processId);
            return callInfo;
        }

        [NonAction]
        partial void HandlePalletScanOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.Receiving.ViewModels.Home.ScanViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult HandlePalletScan(DcmsMobile.Receiving.ViewModels.Home.ScanViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandlePalletScan);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            HandlePalletScanOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void HandleMobileScanOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, DcmsMobile.Receiving.ViewModels.Home.ReceivingViewModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult HandleMobileScan(DcmsMobile.Receiving.ViewModels.Home.ReceivingViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandleMobileScan);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            HandleMobileScanOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void UnPalletizeCartonOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string cartonId, int processId);

        [NonAction]
        public override System.Web.Mvc.ActionResult UnPalletizeCarton(string cartonId, int processId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UnPalletizeCarton);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cartonId", cartonId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "processId", processId);
            UnPalletizeCartonOverride(callInfo, cartonId, processId);
            return callInfo;
        }

        [NonAction]
        partial void PrintCartonOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string cartonId, string printer);

        [NonAction]
        public override System.Web.Mvc.ActionResult PrintCarton(string cartonId, string printer)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PrintCarton);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cartonId", cartonId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "printer", printer);
            PrintCartonOverride(callInfo, cartonId, printer);
            return callInfo;
        }

        [NonAction]
        partial void GetPrintersOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetPrinters()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetPrinters);
            GetPrintersOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void NonpalletizedCartonsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? processId);

        [NonAction]
        public override System.Web.Mvc.ActionResult NonpalletizedCartons(int? processId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.NonpalletizedCartons);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "processId", processId);
            NonpalletizedCartonsOverride(callInfo, processId);
            return callInfo;
        }

        [NonAction]
        partial void ShipmentListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ShipmentList()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShipmentList);
            ShipmentListOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CloseShipmentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string shipmentId, long? poId);

        [NonAction]
        public override System.Web.Mvc.ActionResult CloseShipment(string shipmentId, long? poId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CloseShipment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shipmentId", shipmentId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "poId", poId);
            CloseShipmentOverride(callInfo, shipmentId, poId);
            return callInfo;
        }

        [NonAction]
        partial void ReOpenShipmentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string shipmentId, long? poId);

        [NonAction]
        public override System.Web.Mvc.ActionResult ReOpenShipment(string shipmentId, long? poId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ReOpenShipment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "shipmentId", shipmentId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "poId", poId);
            ReOpenShipmentOverride(callInfo, shipmentId, poId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
