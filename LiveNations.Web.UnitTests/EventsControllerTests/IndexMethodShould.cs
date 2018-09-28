using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LiveNations.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiveNations.Web.UnitTests.EventsControllerTests
{
	[TestClass]
	public class IndexMethodShould
	{
		public EventsControllerSut Sut { get; set; }

		public IndexMethodShould()
		{
			Sut = new EventsControllerSut();
		}

		[TestMethod]
		public void TestMethod1()
		{
			// Arrange
			CityModel city = new CityModel { Id = 1, Name = "New York", Latitude = 40, Longitude = -73 };
			Sut.MockCityService.Setup(x => x.Get(1)).Returns(city);
			Sut.MockEventService.Setup(x => x.GetTopTours(city.Latitude, city.Longitude)).Returns(new List<EventModel>());
			Sut.MockCityService.Setup(x => x.GetAll()).Returns(new List<CityModel> { city });

			// Action
			ViewResult result = Sut.Instance.Index(1) as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}
	}
}
