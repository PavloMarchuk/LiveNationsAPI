using LiveNations.Data.Repositories.Abstract;
using LiveNations.Model.Servicies.Abstract;
using LiveNations.Model.Servicies.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LiveNations.Model.Tests.EventServiceTests
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
