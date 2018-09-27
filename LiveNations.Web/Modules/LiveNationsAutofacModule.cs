using Autofac;
using LiveNations.Data.Repositories.Abstract;
using LiveNations.Data.Repositories.Concrete;
using LiveNations.Model.Servicies.Abstract;
using LiveNations.Model.Servicies.Concrete;

namespace LiveNations.Web.Modules
{
	public class LiveNationsAutofacModule : Module
	{

		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType(typeof(EventRepository))
				.As(typeof(IEventRepositry))
				.InstancePerRequest();



			builder.RegisterType(typeof(EventService))
			.As(typeof(IEventService))
			.InstancePerRequest();

			builder.RegisterType(typeof(CityService))
			.As(typeof(ICityService))
			.InstancePerRequest();

		}
	}
}