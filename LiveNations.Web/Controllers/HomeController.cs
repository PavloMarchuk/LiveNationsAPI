using LiveNations.Data.Models;
using LiveNations.Data.Repositories.Concrete;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LiveNations.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly EventRepository eventRepository;
		public HomeController()
		{
			eventRepository = new EventRepository();
		}
		public ActionResult Index()
		{
			List<EventModel> model = eventRepository.GetTest();
			return View(model);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}