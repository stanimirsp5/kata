


using DataProviderFactory;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
using Microsoft.Data.SqlClient;

//FactoryDbConnection.Start();

Console.WriteLine("Fun with Data Readers");

using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AutoLot;Integrated Security=True"))
{
	connection.Open();
	var sql = "SELECT * FROM Inventory i inner join Makes m on m.Id = i.MakeId";
	SqlCommand command = new SqlCommand(sql, connection);

	using (SqlDataReader reader = command.ExecuteReader())
	{
		while (reader.Read())
		{
			Console.WriteLine($"Car: #{reader["Id"]}, is a {reader["Name"]}");
		}
	}
}

Console.ReadLine();
