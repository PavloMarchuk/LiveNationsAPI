using LiveNations.Data.Models;
using LiveNations.Data.Repositories.Abstract;
using LiveNations.Model.Models;
using LiveNations.Model.Servicies.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveNations.Model.Servicies.Concrete
{
	public class EventService : IEventService
	{
		private readonly IEventRepositry _eventRepository;
		public EventService(IEventRepositry eventRepository)
		{
			_eventRepository = eventRepository;
		}

		public List<EventModel> GetTopTours(int longitude, int latitude)
		{
			List<EventDto> listDTO = _eventRepository.GetTopTours(longitude, latitude);
			List<EventModel> model = listDTO.Select(d => new EventModel
			{
				image_url = d.image_url,
				start_time = DateTime.Parse(d.start_time.Substring(0, 18)).ToLocalTime(),
				title = d.title,
				IsTicketsAreOnSale = DateTime.Compare(DateTime.UtcNow, DateTime.Parse(d.on_sale_at.Substring(0, 18))) > 0 && DateTime.Parse(d.on_sale_at.Substring(0, 18)) > new DateTime(),
				on_sale_at = DateTime.Parse(d.on_sale_at.Substring(0, 18)).ToLocalTime()
			}).ToList();

			return model;
		}
	}
}

//;