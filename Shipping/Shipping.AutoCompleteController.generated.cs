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
    public partial class AutoCompleteController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AutoCompleteController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult CustomerAutocomplete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustomerAutocomplete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult GetCarriers()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetCarriers);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ValidateCarrier()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateCarrier);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AutoCompleteController Actions { get { return MVC_Shipping.Shipping.AutoComplete; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Shipping";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "AutoComplete";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "AutoComplete";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string CustomerAutocomplete = "CustomerAutocomplete";
            public readonly string ValidateCustomer = "ValidateCustomer";
            public readonly string GetCarriers = "GetCarriers";
            public readonly string ValidateCarrier = "ValidateCarrier";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string CustomerAutocomplete = "CustomerAutocomplete";
            public const string ValidateCustomer = "ValidateCustomer";
            public const string GetCarriers = "GetCarriers";
            public const string ValidateCarrier = "ValidateCarrier";
        }


        static readonly ActionParamsClass_CustomerAutocomplete s_params_CustomerAutocomplete = new ActionParamsClass_CustomerAutocomplete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CustomerAutocomplete CustomerAutocompleteParams { get { return s_params_CustomerAutocomplete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CustomerAutocomplete
        {
            public readonly string term = "term";
        }
        static readonly ActionParamsClass_GetCarriers s_params_GetCarriers = new ActionParamsClass_GetCarriers();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetCarriers GetCarriersParams { get { return s_params_GetCarriers; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetCarriers
        {
            public readonly string term = "term";
        }
        static readonly ActionParamsClass_ValidateCarrier s_params_ValidateCarrier = new ActionParamsClass_ValidateCarrier();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ValidateCarrier ValidateCarrierParams { get { return s_params_ValidateCarrier; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ValidateCarrier
        {
            public readonly string term = "term";
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
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_AutoCompleteController : DcmsMobile.Shipping.Areas.Shipping.Controllers.AutoCompleteController
    {
        public T4MVC_AutoCompleteController() : base(Dummy.Instance) { }

        [NonAction]
        partial void CustomerAutocompleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string term);

        [NonAction]
        public override System.Web.Mvc.ActionResult CustomerAutocomplete(string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CustomerAutocomplete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            CustomerAutocompleteOverride(callInfo, term);
            return callInfo;
        }

        [NonAction]
        partial void ValidateCustomerOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

        [NonAction]
        public override System.Web.Mvc.JsonResult ValidateCustomer()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.ValidateCustomer);
            ValidateCustomerOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetCarriersOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string term);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetCarriers(string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetCarriers);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            GetCarriersOverride(callInfo, term);
            return callInfo;
        }

        [NonAction]
        partial void ValidateCarrierOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string term);

        [NonAction]
        public override System.Web.Mvc.ActionResult ValidateCarrier(string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ValidateCarrier);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            ValidateCarrierOverride(callInfo, term);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
