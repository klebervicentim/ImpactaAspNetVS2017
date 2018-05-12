using System.Web.Mvc;
using log4net;

namespace Loja.Mvc
{
    internal class LogErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"].ToString();
            var action = filterContext.RouteData.Values["action"].ToString();
            var loggername = $"{controller}Controller.{action}";

            LogManager.GetLogger(loggername).Error(filterContext.Exception.Message, filterContext.Exception);

            base.OnException(filterContext);
        }
    }
}