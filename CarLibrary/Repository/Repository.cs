using CarLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary.Repository
{
	public class Repository<T> : IRepository<T>, IDisposable where T : class
	{

		private readonly AutoLotContext context;
		private readonly DbSet<T> dbSet;

		public Repository(AutoLotContext context)
		{
			this.context = context ?? throw new ArgumentNullException(nameof(context));
			dbSet = context.Set<T>();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public T GetOne(int id)
		{
			return dbSet.Find(id);
		}




	}
}
