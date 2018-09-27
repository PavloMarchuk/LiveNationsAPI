using LiveNations.Model.Models;
using LiveNations.Model.Servicies.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LiveNations.Web.Controllers
{
	public class EventsController : Controller
	{
		private readonly IEventService _eventService;
		private readonly ICityService _cityService;

		public EventsController(IEventService eventService, ICityService cityService)
		{
			_eventService = eventService;
			_cityService = cityService;
		}

		[HttpGet]
		public ActionResult Index(int id = 1)
		{
			CityModel city = _cityService.Get(id);
			List<EventModel> model = _eventService.GetTopTours(city.Latitude, city.Longitude);

			List<CityModel> cities = _cityService.GetAll();
			ViewBag.CityIdSelectList = new SelectList(GetCity.Union(cities), "Id", "Name", city.Id);
			return View(model);
		}

		private IEnumerable<CityModel> GetCity
		{
			get
			{
				yield return new CityModel { Id = 0, Name = "Select City" };
			}
		}
	}
}