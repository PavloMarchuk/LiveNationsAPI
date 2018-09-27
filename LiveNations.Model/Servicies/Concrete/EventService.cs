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
		public List<EventModel> GetTest()
		{
			List<EventDTO> listDTO = _eventRepository.GetTest();
			List<EventModel> model = listDTO.Select(d => new EventModel
			{
				image_url = d.image_url,
				start_time = d.start_time,
				title = d.title,
				IsTicketsAreOnSale = DateTime.Compare(DateTime.UtcNow, d.start_time) > 0
			}).ToList();

			return model;
		}
	}
}
