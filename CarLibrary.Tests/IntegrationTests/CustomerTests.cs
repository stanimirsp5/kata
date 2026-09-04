using CarLibrary.Tests.BaseTest;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace CarLibrary.IntegrationTests
{
	[Collection("Integration Tests")]
	public class CustomerTests : BaseTest, IClassFixture<EnsureAutoLotDatabaseTestFixture>
	{
		public CustomerTests(ITestOutputHelper outputHelper) : base(outputHelper)
		{
		}
	}
}
