using LiveNations.Data.Models;
using System.Collections.Generic;

namespace LiveNations.Data.Repositories.Abstract
{
	public interface IEventRepositry
	{
		List<EventDTO> GetTopTours(int longitude, int latitude);
	}
}
