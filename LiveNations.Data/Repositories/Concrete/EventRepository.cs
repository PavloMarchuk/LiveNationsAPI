using LiveNations.Data.Models;
using LiveNations.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveNations.Data.Repositories.Concrete
{
	public class EventRepository : IEventRepositry
	{
		public List<EventDTO> GetTest()
		{
			List<EventDTO> list = new List<EventDTO>
			{
				new EventDTO
				{
				image_url = @"https://www.w3schools.com/TAGS/smiley.gif",
				start_time = DateTime.UtcNow,
				on_sale_at = DateTime.UtcNow.AddDays(-2),
				title = "PM1"
				},
				new EventDTO
				{
				image_url = @"https://scontent.fiev15-1.fna.fbcdn.net/v/t1.0-9/12193334_891748340932542_4525146012619504270_n.jpg?_nc_cat=107&oh=5d453151b45bf41bb8f2b4c096324791&oe=5C144EDD",
				start_time = DateTime.UtcNow.AddDays(5).Date,
				on_sale_at = DateTime.UtcNow.AddDays(2),
				title = "PM2"
				},
			};
			return list;
		}
	}
}
