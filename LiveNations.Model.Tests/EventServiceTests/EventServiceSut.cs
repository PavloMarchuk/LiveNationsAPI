using LiveNations.Data.Repositories.Abstract;
using LiveNations.Model.Servicies.Abstract;
using LiveNations.Model.Servicies.Concrete;
using Moq;

namespace LiveNations.Model.UnitTests.EventServiceTests
{
	public class EventServiceSut
	{
		public IEventService Instance { get; set; }
		public Mock<IEventRepositry> MockEventRepositry { get; set; }

		public EventServiceSut()
		{
			MockEventRepositry = new Mock<IEventRepositry>();
			Instance = new EventService(MockEventRepositry.Object);
		}
	}
}
