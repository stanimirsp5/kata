using CarLibrary.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace CarLibrary.Tests.BaseTest
{
	public abstract class BaseTest : IDisposable
	{
		protected readonly IConfiguration Configuration;
		protected readonly AutoLotContext Context;
		protected readonly ITestOutputHelper OutputHelper;
		protected BaseTest(ITestOutputHelper outputHelper)
		{
			Configuration = TestHelpers.GetConfiguration();
			Context = TestHelpers.GetContext(Configuration);
			OutputHelper = outputHelper;
		}


		public virtual void Dispose()
		{
			Context.Dispose();
		}
	}
}
