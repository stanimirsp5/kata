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
	public class MakeTests
: BaseTest, IClassFixture<EnsureAutoLotDatabaseTestFixture>
	{
		private readonly IRepository<Make> _repo;
		public MakeTests(ITestOutputHelper outputHelper) : base(outputHelper)
		{
			_repo = new Repository<Make>(Context);
		}
		public override void Dispose()
		{
			_repo.Dispose();
			base.Dispose();
		}
	}
}
