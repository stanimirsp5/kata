using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary.Repository
{
	public interface IRepository<T>
	{
		public T GetOne(int id);
		public void Dispose();
	}
}
