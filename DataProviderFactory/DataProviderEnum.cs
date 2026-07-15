using System;
using System.Collections.Generic;
using System.Text;

namespace DataProviderFactory
{
	public enum DataProviderEnum
	{
		SqlServer,
	#if PC
		OleDb,
	#endif
		Odbc,
	}
}
