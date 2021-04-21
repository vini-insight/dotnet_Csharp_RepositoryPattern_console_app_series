using System;
using System.Collections.Generic;
using Interfaces;

namespace Models
{
	public class SerieRepository : IRepository<Serie>
	{
        private List<Serie> serieList = new List<Serie>();		

		public void Add(Serie obj)
		{
			serieList.Add(obj);
		}

		public void Update(int id, Serie obj)
		{
			serieList[id] = obj;
		}

		public List<Serie> List()
		{
			return serieList;
		}

		public int NextId()
		{
			return serieList.Count;
		}

		public Serie GetById(int id)
		{
			return serieList[id];
		}
		public void Delete(int id)
		{
			serieList[id].SetDeleted();
		}
	}
}