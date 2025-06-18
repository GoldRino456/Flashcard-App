using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Utilities.GoldRino456;

namespace Flashcards.GoldRino456
{
    internal class DatabaseManager
    {
        //Reusable SQL Commands
        

        private readonly string _connectionString;

        public DatabaseManager()
        {
            FetchConnectionString(out _connectionString);
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            //Create Stacks Table
            DatabaseUtils.ExecuteNonQueryCommand(_connectionString, "IF OBJECT_ID(N'Stacks', N'U') IS NULL CREATE TABLE Stacks (stackID INT IDENTITY(1,1) PRIMARY KEY, stackName VARCHAR(50));");

            //Create Cards Table
            DatabaseUtils.ExecuteNonQueryCommand(_connectionString, "IF OBJECT_ID(N'Cards', N'U') IS NULL CREATE TABLE Cards (cardID INT IDENTITY(1,1) PRIMARY KEY, stackID INT FOREIGN KEY REFERENCES Stacks(stackID), frontOfCard VARCHAR(500), backOfCard VARCHAR(500));");

            //Create Sessions Table
            DatabaseUtils.ExecuteNonQueryCommand(_connectionString, "IF OBJECT_ID(N'Sessions', N'U') IS NULL CREATE TABLE Sessions (sessionID INT IDENTITY(1,1) PRIMARY KEY, stackID INT FOREIGN KEY REFERENCES Stacks(stackID), sessionDate DATE, backOfCard VARCHAR(500));");
        }

        private void FetchConnectionString(out string connectionString)
        {
            IConfiguration config = new ConfigurationBuilder()
                        .AddJsonFile("appSettings.json")
                        .Build();

            connectionString = config.GetConnectionString("DefaultConnection");
        }
    }
}
