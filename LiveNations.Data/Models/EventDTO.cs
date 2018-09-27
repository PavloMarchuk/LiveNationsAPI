using System;

namespace LiveNations.Data.Models
{
	public class EventDTO
	{
		public string title { get; set; }
		public DateTime start_time { get; set; }
		public string image_url { get; set; }
		public DateTime on_sale_at { get; set; }
	}
}
