using System.Data;
using Npgsql;
using Domain;

namespace DataAccess;

public abstract class Repository<T> : IRepository<T> where T : class
{
    private string _connectionString;

    public Repository(IDbConfiguration dbConfig)
    {
        _connectionString = dbConfig.ConnectionString;
    }

    public IDbConnection Open()
    {
        NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        return connection;
    }

    public abstract Task<IEnumerable<T>> GetAsync();
}