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
	[Collection("Integation Tests")]
	public class CustomerOrderViewModelTests
	: BaseTest, IClassFixture<EnsureAutoLotDatabaseTestFixture>
	{
		private readonly IRepository<Order> _repo;
		public CustomerOrderViewModelTests(ITestOutputHelper outputHelper) : base(outputHelper)
		{
			_repo = new Repository<Order>(Context);
		}
		public override void Dispose()
		{
			_repo.Dispose();
			base.Dispose();
		}
	}
}
