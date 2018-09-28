using System;
using System.Collections.Generic;
using LiveNations.Data.Models;
using LiveNations.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiveNations.Model.Tests.EventServiceTests
{
	[TestClass]
	public class GetTopToursMethodShould
	{
		private EventServiceSut Sut { get; set; }

		private List<EventDto> ListDto { get; set; }

		public GetTopToursMethodShould()
		{
			Sut = new EventServiceSut();
			ListDto = ListDtoSeed();
		}

		[TestMethod]
		public void ReturnModels()
		{
			// Arrange
			Sut.MockEventRepositry.Setup(x => x.GetTopTours(30,-115)).Returns(ListDto);

			// Action
			List<EventModel> actualResult = Sut.Instance.GetTopTours(30, -115);

			// Assert
			Assert.IsNotNull(actualResult);
		}

		private List<EventDto> ListDtoSeed()
		{
			List<EventDto> result = new List<EventDto>
			{
				new EventDto
				{
					title = "First",
					image_url = "https://media.livenation.com/artists/162141/162141-homepage-4070137.jpg?1533126872",
					on_sale_at = "2018-09-28 14:00:00 UTC",
					start_time = "2019-02-25 01:00:00 UTC"
				},
				new EventDto
				{
					title = "Second",
					image_url = "https://media.livenation.com/artists/43478/43478-homepage-4641399.jpg?1537311193",
					on_sale_at = "2018-09-21 15:00:00 UTC",
					start_time = "2018-12-18 01:00:00 UTC"
				}
			};

			return result;
		}
	}
}
