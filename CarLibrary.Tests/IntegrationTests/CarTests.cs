using CarLibrary.Entities;
using CarLibrary.Repository;
using CarLibrary.Tests.BaseTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CarLibrary.IntegrationTests
{
	[Collection("Integration Tests")]
	public class CarTests : BaseTest, IClassFixture<EnsureAutoLotDatabaseTestFixture>
	{
		private readonly IRepository<Car> _carRepo;
		public CarTests(ITestOutputHelper outputHelper) : base(outputHelper)
		{
			_carRepo = new Repository<Car>(Context);
		}
		public override void Dispose()
		{
			_carRepo.Dispose();
			base.Dispose();
		}
	}
}
