using System;
using System.ComponentModel;

namespace LiveNations.Model.Models
{
	public class EventModel
	{
		[DisplayName("Event")]
		public string title { get; set; }

		[DisplayName("Date")]
		public DateTime start_time { get; set; }

		public string image_url { get; set; }
		[DisplayName("On sale Date")]
		public DateTime on_sale_at { get; set; }
		[DisplayName("Tickets Available")]
		public bool IsTicketsAreOnSale { get; set; }
	}
}
