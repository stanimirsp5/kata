using CarLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace CarLibrary.Tests
{
	public static class TestHelpers
	{
		public static IConfiguration GetConfiguration() =>
			new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.testing.json", true, true)
			.Build();

		public static AutoLotContext GetContext(IConfiguration configuration)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AutoLotContext>();
			var connectionString = configuration.GetConnectionString("AutoLot");
			optionsBuilder.UseSqlServer(connectionString);
			return new AutoLotContext(optionsBuilder.Options);
		}


		public static AutoLotContext GetContext (AutoLotContext oldContext, IDbContextTransaction trans)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AutoLotContext>();
					optionsBuilder.UseSqlServer(oldContext.Database.GetDbConnection());
			var context = new AutoLotContext(optionsBuilder.Options);
					context.Database.UseTransaction(trans.GetDbTransaction());
			return context;
		}
	}
}