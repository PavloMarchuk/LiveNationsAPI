using LiveNations.Model.Models;
using System.Collections.Generic;

namespace LiveNations.Model.Servicies.Abstract
{
	public interface ICityService
	{
		List<CityModel> GetAll();
		CityModel Get(int id);
	}
}
