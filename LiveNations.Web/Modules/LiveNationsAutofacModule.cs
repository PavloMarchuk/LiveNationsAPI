using Autofac;
using LiveNations.Data.Repositories.Abstract;
using LiveNations.Data.Repositories.Concrete;
namespace LiveNations.Web.Modules
{
	public class LiveNationsAutofacModule : Module
	{

		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType(typeof(EventRepository))
				.As(typeof(IEventRepositry))
				.InstancePerRequest();
		}
	}
}