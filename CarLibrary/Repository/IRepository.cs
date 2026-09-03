using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary.Repository
{
	internal interface IRepository<T>
	{
		public T GetOne(int id);
	}
}
