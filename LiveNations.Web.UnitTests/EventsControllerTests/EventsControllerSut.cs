using LiveNations.Model.Servicies.Abstract;
using LiveNations.Web.Controllers;
using Moq;

namespace LiveNations.Web.UnitTests.EventsControllerTests
{
	public class EventsControllerSut
	{
		public EventsController Instance { get; set; }
		public Mock<IEventService> MockEventService { get; set; }
		public Mock<ICityService> MockCityService { get; set; }

		public EventsControllerSut()
		{
			MockEventService = new Mock<IEventService>();
			MockCityService = new Mock<ICityService>();
			Instance = new EventsController(MockEventService.Object, MockCityService.Object);
		}
	}
}