using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .Build();

var connectionString = config.GetConnectionString("DefaultConnection");
Console.WriteLine(connectionString);

var connection = new SqlConnection(connectionString);
connection.Open();

var query = connection.QuerySingle<string>("SELECT DB_NAME(db_id())");

Console.WriteLine(query);