using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public static class HtmlExtensions
    {
        private static string GetControllerName(Type controllerType)
        {
            var controllerName = controllerType.Name.EndsWith("Controller")
                ? controllerType.Name.Substring(0, controllerType.Name.Length - "Controller".Length)
                : controllerType.Name;
            return controllerName;
        }

        private static string GetActionName(MethodCallExpression call)
        {
            return call.Method.Name; ;
        }
        public static string ActionName<TController>(this IHtmlHelper helper, Expression<Func<TController,ActionResult>> expression)
        {
            return GetActionName((MethodCallExpression)expression.Body);
        }

        public static string ControllerName<TController>(this IHtmlHelper helper)
        {
            return GetControllerName(typeof(TController));
        }
        public static MvcForm BeginForm<TController>(this IHtmlHelper helper, Expression<Func<TController,ActionResult>> actionSelector, FormMethod method,object htmlAttributes)
        {
            var action = GetActionName((MethodCallExpression)actionSelector.Body);
            var controller = GetControllerName(typeof(TController));
            return helper.BeginForm(action, controller, method, htmlAttributes);
        }
        public static string ViewControllerName(this IHtmlHelper helper)
        {
            return helper.ViewContext.RouteData.Values["controller"].ToString();
        }
        public static string ViewActionName(this IHtmlHelper helper)
        {
            return helper.ViewContext.RouteData.Values["action"].ToString();
        }
        public static string ViewAreaName(this IHtmlHelper helper)
        {
            return helper.ViewContext.RouteData.DataTokens["area"]?.ToString();
        }
    }

    public static class UrlExtensions
    {
        private static string GetControllerName(Type controllerType)
        {
            var controllerName = controllerType.Name.EndsWith("Controller")
                ? controllerType.Name.Substring(0, controllerType.Name.Length - "Controller".Length)
                : controllerType.Name;
            return controllerName;
        }

        private static string GetActionName(MethodCallExpression call)
        {
            return call.Method.Name; ;
        }

        private static RouteValueDictionary GetRouteValues(MethodCallExpression call)
        {
            var routeValues = new RouteValueDictionary();

            var args = call.Arguments;
            ParameterInfo[] parameters = call.Method.GetParameters();
            var pairs = args.Select((a, i) => new
            {
                Argument = a,
                ParamName = parameters[i].Name
            });
            foreach (var argumentParameterPair in pairs)
            {
                string name = argumentParameterPair.ParamName;
                object value = null;
                if (argumentParameterPair.Argument is MethodCallExpression)
                {
                    var subcall = (MethodCallExpression)argumentParameterPair.Argument;
                    var func = Expression.Lambda(subcall).Compile();
                    //object[] subargs =
                    value = func.DynamicInvoke(null);
                }
                else
                    value = ((ConstantExpression)argumentParameterPair.Argument).Value;
                if (value != null)
                {
                    var valueType = value.GetType();
                    if (valueType.GetTypeInfo().IsValueType || valueType == typeof(string))
                    {
                        routeValues.Add(name, value);
                    }
                    else throw new NotSupportedException($"unsoupported parameter type {valueType.ToString()}");
                }
            }
            return routeValues;
        }
        private static RouteValueDictionary GetRouteValues2(MethodCallExpression call)
        {
            var routeValues = new RouteValueDictionary();

            var args = call.Arguments;
            ParameterInfo[] parameters = call.Method.GetParameters();
            var pairs = args.Select((a, i) => new
            {
                Argument = a,
                ParamName = parameters[i].Name
            });
            foreach (var argumentParameterPair in pairs)
            {
                string name = argumentParameterPair.ParamName;
                object value = Run(call);
                if (value != null)
                {
                    var valueType = value.GetType();
                    if (valueType.GetTypeInfo().IsValueType || valueType == typeof(string))
                    {
                        routeValues.Add(name, value);
                    }
                    else throw new NotSupportedException($"unsoupported parameter type {valueType.ToString()}");
                }
            }
            return routeValues;
        }
        private static object Run(MethodCallExpression call)
        {
            object value = null;

            foreach (var Argument in call.Arguments)
            {
                if (Argument is MethodCallExpression)
                {
                    var subcall = (MethodCallExpression)Argument;
                    var objs = new List<object>();
                    foreach (var arg in subcall.Arguments)
                    {
                        if (arg is ConstantExpression)
                        {
                            var x = ((ConstantExpression)arg).Value;
                            objs.Add(x);
                        }
                        else if (arg is MethodCallExpression)
                        {
                            var x = Run((MethodCallExpression)arg);
                            var y = (MethodCallExpression)arg;
                            objs.Add(y.Method.Invoke(null,new object[] { x }));
                        }
                    }
                    object[] a = objs.ToArray();
                    //var func = Expression.Lambda(subcall).Compile();
                    //value = func.DynamicInvoke();
                    value = subcall.Method.Invoke(null, a);
                }
                else
                    value = ((ConstantExpression)Argument).Value;
            }
            return value;
        }

        public static string Action<TController>(this IUrlHelper url, Expression<Func<TController, IActionResult>> actionSelector, string protocol = null, string hostname = null)
        {
            var action = GetActionName((MethodCallExpression)actionSelector.Body);
            var controller = GetControllerName(typeof(TController));
            var routeValues = GetRouteValues2((MethodCallExpression)actionSelector.Body);

            return url.Action(action, controller, routeValues, protocol, hostname);
        }
    }
}