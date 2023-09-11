using System.Web.Http;
using Unity;
using Unity.WebApi;
using Wingman.Reporting.Services.Services;

namespace Wingman.Web.Reporting
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IReportService, ReportService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}