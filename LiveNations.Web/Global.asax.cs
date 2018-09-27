using Autofac;
using Autofac.Integration.Mvc;
using LiveNations.Web.Modules;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LiveNations.Web
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			//using Autofac;
			var builder = new ContainerBuilder();
			builder.RegisterControllers(typeof(MvcApplication).Assembly)
				.PropertiesAutowired();
			builder.RegisterModule(new LiveNationsAutofacModule());

			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}
