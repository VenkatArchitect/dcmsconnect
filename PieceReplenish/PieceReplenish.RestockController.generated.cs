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
namespace DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers
{
    public partial class RestockController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RestockController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult UPC1()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UPC1);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UPC()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UPC);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult HandleUpc()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandleUpc);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Location()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Location);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RestockCarton()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestockCarton);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public RestockController Actions { get { return MVC_PieceReplenish.PieceReplenish.Restock; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "PieceReplenish";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Restock";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Restock";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Carton = "Carton";
            public readonly string UPC1 = "UPC1";
            public readonly string UPC = "UPC";
            public readonly string HandleUpc = "HandleUpc";
            public readonly string Location = "Location";
            public readonly string RestockCarton = "RestockCarton";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Carton = "Carton";
            public const string UPC1 = "UPC1";
            public const string UPC = "UPC";
            public const string HandleUpc = "HandleUpc";
            public const string Location = "Location";
            public const string RestockCarton = "RestockCarton";
        }


        static readonly ActionParamsClass_Carton s_params_Carton = new ActionParamsClass_Carton();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Carton CartonParams { get { return s_params_Carton; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Carton
        {
            public readonly string lastCartonId = "lastCartonId";
        }
        static readonly ActionParamsClass_UPC1 s_params_UPC1 = new ActionParamsClass_UPC1();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UPC1 UPC1Params { get { return s_params_UPC1; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UPC1
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_UPC s_params_UPC = new ActionParamsClass_UPC();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UPC UPCParams { get { return s_params_UPC; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UPC
        {
            public readonly string cartonId = "cartonId";
            public readonly string lastUpcCode = "lastUpcCode";
            public readonly string ignoreCache = "ignoreCache";
            public readonly string lastCartonId = "lastCartonId";
        }
        static readonly ActionParamsClass_HandleUpc s_params_HandleUpc = new ActionParamsClass_HandleUpc();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_HandleUpc HandleUpcParams { get { return s_params_HandleUpc; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_HandleUpc
        {
            public readonly string cartonId = "cartonId";
            public readonly string upcCode = "upcCode";
            public readonly string lastUpcCode = "lastUpcCode";
        }
        static readonly ActionParamsClass_Location s_params_Location = new ActionParamsClass_Location();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Location LocationParams { get { return s_params_Location; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Location
        {
            public readonly string cartonId = "cartonId";
            public readonly string lastLocationId = "lastLocationId";
        }
        static readonly ActionParamsClass_RestockCarton s_params_RestockCarton = new ActionParamsClass_RestockCarton();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RestockCarton RestockCartonParams { get { return s_params_RestockCarton; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RestockCarton
        {
            public readonly string cartonId = "cartonId";
            public readonly string locationId = "locationId";
            public readonly string lastLocationId = "lastLocationId";
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
                public readonly string _locationSuggestionsPartial = "_locationSuggestionsPartial";
                public readonly string Carton = "Carton";
                public readonly string Location = "Location";
                public readonly string Upc = "Upc";
            }
            public readonly string _locationSuggestionsPartial = "~/Areas/PieceReplenish/Views/Restock/_locationSuggestionsPartial.cshtml";
            public readonly string Carton = "~/Areas/PieceReplenish/Views/Restock/Carton.cshtml";
            public readonly string Location = "~/Areas/PieceReplenish/Views/Restock/Location.cshtml";
            public readonly string Upc = "~/Areas/PieceReplenish/Views/Restock/Upc.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_RestockController : DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.RestockController
    {
        public T4MVC_RestockController() : base(Dummy.Instance) { }

        [NonAction]
        partial void CartonOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string lastCartonId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Carton(string lastCartonId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Carton);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "lastCartonId", lastCartonId);
            CartonOverride(callInfo, lastCartonId);
            return callInfo;
        }

        [NonAction]
        partial void UPC1Override(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult UPC1(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UPC1);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            UPC1Override(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void UPCOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string cartonId, string lastUpcCode, bool? ignoreCache, string lastCartonId);

        [NonAction]
        public override System.Web.Mvc.ActionResult UPC(string cartonId, string lastUpcCode, bool? ignoreCache, string lastCartonId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UPC);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cartonId", cartonId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "lastUpcCode", lastUpcCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ignoreCache", ignoreCache);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "lastCartonId", lastCartonId);
            UPCOverride(callInfo, cartonId, lastUpcCode, ignoreCache, lastCartonId);
            return callInfo;
        }

        [NonAction]
        partial void HandleUpcOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string cartonId, string upcCode, string lastUpcCode);

        [NonAction]
        public override System.Web.Mvc.ActionResult HandleUpc(string cartonId, string upcCode, string lastUpcCode)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.HandleUpc);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cartonId", cartonId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "upcCode", upcCode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "lastUpcCode", lastUpcCode);
            HandleUpcOverride(callInfo, cartonId, upcCode, lastUpcCode);
            return callInfo;
        }

        [NonAction]
        partial void LocationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string cartonId, string lastLocationId);

        [NonAction]
        public override System.Web.Mvc.ActionResult Location(string cartonId, string lastLocationId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Location);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cartonId", cartonId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "lastLocationId", lastLocationId);
            LocationOverride(callInfo, cartonId, lastLocationId);
            return callInfo;
        }

        [NonAction]
        partial void RestockCartonOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string cartonId, string locationId, string lastLocationId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RestockCarton(string cartonId, string locationId, string lastLocationId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RestockCarton);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "cartonId", cartonId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "locationId", locationId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "lastLocationId", lastLocationId);
            RestockCartonOverride(callInfo, cartonId, locationId, lastLocationId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
