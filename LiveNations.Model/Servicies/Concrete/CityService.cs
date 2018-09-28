using LiveNations.Model.Models;
using LiveNations.Model.Servicies.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveNations.Model.Servicies.Concrete
{
	public class CityService : ICityService
	{
		private readonly List<CityModel> _cities;

		public CityService()
		{
			_cities = SitiesSeed();
		}

		public List<CityModel> GetAll()
		{
			return _cities;
		}

		public CityModel Get(int id)
		{
			CityModel cityModel = _cities.FirstOrDefault(c => c.Id == id);
			if (cityModel == null)
			{
				throw new Exception("City not found");
			}

			return cityModel;
		}

		private List<CityModel> SitiesSeed()
		{
			List<CityModel> cities = new List<CityModel>
			{
				new CityModel
				{
					Id = 1,
					Name = "New York",
					Latitude = 40,
					Longitude= -73
				},
				new CityModel{
					Id = 2,
					Name = "Los Angeles",
					Latitude = 34,
					Longitude= -118
				} ,
				new CityModel
				{
					Id = 3,
					Name = "San Francisco",
					Latitude = 37,
					Longitude= -122
				}
			};

			return cities;
		}
	}
}
