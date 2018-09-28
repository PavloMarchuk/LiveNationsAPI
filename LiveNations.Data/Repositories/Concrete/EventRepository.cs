using LiveNations.Data.Models;
using LiveNations.Data.Repositories.Abstract;
using RestSharp;
using System.Collections.Generic;

namespace LiveNations.Data.Repositories.Concrete
{
	public class EventRepository : IEventRepositry
	{
		public List<EventDto> GetTopTours(int longitude, int latitude)
		{
			string location = longitude.ToString() + "," + latitude.ToString();
			RestClient client = new RestClient(@"https://api.livenation.com/charts/top-tours?location=" + location);
			RestRequest request = new RestRequest(Method.GET);
			ResponceObject responceData = client.Execute<ResponceObject>(request).Data;

			List<EventDto> result = responceData.data.items;
			return result;
		}
	}
}


public class ResponceObject
{

	public ResponceData data { get; set; }
}

public class ResponceData
{
	public List<EventDto> items { get; set; }
}