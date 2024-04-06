using System.Data;
using Microsoft.Data.Sqlite;
namespace Library.Api.Data;

public class SqliteConnectionFactory(string connectionString) : IDbConnectionFactory
{
    private readonly string _connectionString = connectionString;

    public async Task<IDbConnection> CreateConnectionAsync()
    {
        var connection = new SqliteConnection(_connectionString);
        await connection.OpenAsync();
        return connection;
    }
}
