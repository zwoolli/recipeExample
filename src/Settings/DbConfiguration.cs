using DataAccess;

namespace Settings;

public class DbConfiguration : IDbConfiguration
{
    private readonly string _connectionString;

    public DbConfiguration(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("recipe");
        if (string.IsNullOrWhiteSpace(_connectionString)) throw new ArgumentNullException(nameof(_connectionString));
    }

    public string ConnectionString
    {
        get
        {
            return _connectionString;
        }
    }
}