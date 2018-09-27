using System;

namespace LiveNations.Model.Models
{
	public class EventModel
	{
		public string title { get; set; }
		public DateTime start_time { get; set; }
		public string image_url { get; set; }
		public bool IsTicketsAreOnSale { get; set; }
	}
}
