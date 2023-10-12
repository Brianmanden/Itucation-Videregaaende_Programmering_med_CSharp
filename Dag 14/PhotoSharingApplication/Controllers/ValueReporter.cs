using System.Web.Mvc;
using System.Diagnostics;
using System.Web.Routing;
using Microsoft.Ajax.Utilities;

namespace PhotoSharingApplication.Controllers
{
    public class ValueReporter : ActionFilterAttribute
    {
        private void LogValues(RouteData routeData)
        {
            string controllerName = routeData.Values["controller"].ToString();
            string actionName = routeData.Values["action"].ToString();

            Debug.WriteLine($"Controller: { controllerName } - Action: { actionName }", "Action Values");

            routeData.Values.ForEach(item =>
            {
                var bp = "";
                Debug.WriteLine(">>> Key: {0} : Value: {1}", item.Key, item.Value);
            });
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogValues(filterContext.RouteData);
        }
    }
}