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
namespace DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers
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
        public virtual System.Web.Mvc.ActionResult SkuAutocomplete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuAutocomplete);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AutoCompleteController Actions { get { return MVC_PieceReplenish.PieceReplenish.AutoComplete; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "PieceReplenish";
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
            public readonly string SkuAutocomplete = "SkuAutocomplete";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string SkuAutocomplete = "SkuAutocomplete";
        }


        static readonly ActionParamsClass_SkuAutocomplete s_params_SkuAutocomplete = new ActionParamsClass_SkuAutocomplete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SkuAutocomplete SkuAutocompleteParams { get { return s_params_SkuAutocomplete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SkuAutocomplete
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
    public partial class T4MVC_AutoCompleteController : DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.AutoCompleteController
    {
        public T4MVC_AutoCompleteController() : base(Dummy.Instance) { }

        [NonAction]
        partial void SkuAutocompleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string term);

        [NonAction]
        public override System.Web.Mvc.ActionResult SkuAutocomplete(string term)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SkuAutocomplete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            SkuAutocompleteOverride(callInfo, term);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
