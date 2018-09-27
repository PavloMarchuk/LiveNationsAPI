using LiveNations.Model.Models;
using LiveNations.Model.Servicies.Abstract;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LiveNations.Web.Controllers
{
	public class EventsController : Controller
	{
		private readonly IEventService _eventService;
		public EventsController(IEventService eventService)
		{
			_eventService = eventService;
		}

		public ActionResult Index()
		{
			List<EventModel> model = _eventService.GetTopTours(40, -73);
			return View(model);
		}
	}
}