


using DataProviderFactory;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

Console.WriteLine("Fun with Data Provider Factories");



var (provider, connectionString) = GetDataProviderFromConfiguration();
DbProviderFactory factory = GetDbProviderFactory(provider);

using (DbConnection connection = factory.CreateConnection())
{
	Console.WriteLine($"Your connection object is of type {connection.GetType().Name}");
	connection.ConnectionString = connectionString;
	connection.Open();

	DbCommand command = factory.CreateCommand();
	Console.WriteLine($"Your command object is of type {command.GetType().Name}");
	command.Connection = connection;
	command.CommandText = "SELECT * FROM Inventory i inner join Makes m on m.Id = i.MakeId";

	// Print data with data reader
	using (DbDataReader reader = command.ExecuteReader())
	{
		Console.WriteLine($"Your data reader object is of type {reader.GetType().Name}");

		while (reader.Read())
		{
			Console.WriteLine($"Car: #{reader["Id"]}, is a {reader["Name"]}");
		}
	}
}
Console.ReadLine();


static DbProviderFactory GetDbProviderFactory(DataProviderEnum provider) => provider switch
{
	DataProviderEnum.SqlServer => Microsoft.Data.SqlClient.SqlClientFactory.Instance,
	DataProviderEnum.Odbc => System.Data.Odbc.OdbcFactory.Instance,
#if PC
	DataProviderEnum.OleDb => System.Data.OleDb.OleDbFactory.Instance,
#endif
	_ => throw new ArgumentException("Invalid data provider value supplied.")
};

static (DataProviderEnum Provider, string ConnectionString) GetDataProviderFromConfiguration()
{

	IConfiguration config = new ConfigurationBuilder()
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
		.Build();
	var providerName = config["ProviderName"];

	if (Enum.TryParse<DataProviderEnum>(providerName, out var provider))
	{
		var connectionString = config[$"{providerName}:ConnectionString"];
		return (provider, connectionString);
	}

	throw new Exception("Invalid data provider value supplied.");
}