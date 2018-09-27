using LiveNations.Model.Models;
using LiveNations.Model.Servicies.Abstract;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LiveNations.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly IEventService _eventService;
		public HomeController(IEventService eventService)
		{
			_eventService = eventService;
		}
	 
		public ActionResult Index()
		{
			List<EventModel> model = _eventService.GetTest();
			return View(model);
		} 
	}
}