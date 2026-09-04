using CarLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
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

		// Execute a given action within a transaction and roll it back after execution
		protected void ExecuteInATransaction(Action actionToExecute)
		{
			var strategy = Context.Database.CreateExecutionStrategy();
			strategy.Execute(() =>
			{
				using var trans = Context.Database.BeginTransaction();
				actionToExecute();
				trans.Rollback();
			});
		}

		// Execute a given action within a transaction and roll it back after execution, passing the transaction to the action
		protected void ExecuteInASharedTransaction(Action<IDbContextTransaction> actionToExecute)
		{
			var strategy = Context.Database.CreateExecutionStrategy();
			strategy.Execute(() =>
			{
				using IDbContextTransaction trans =
				Context.Database.BeginTransaction(IsolationLevel.ReadUncommitted);
				actionToExecute(trans);
				trans.Rollback();
			});
		}

		public virtual void Dispose()
		{
			Context.Dispose();
		}
	}
}
