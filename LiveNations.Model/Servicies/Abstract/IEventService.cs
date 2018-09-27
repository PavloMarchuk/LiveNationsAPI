using LiveNations.Model.Models;
using System.Collections.Generic;

namespace LiveNations.Model.Servicies.Abstract
{
	public interface IEventService
	{
		List<EventModel> GetTopTours(int longitude, int latitude);
	}
}
