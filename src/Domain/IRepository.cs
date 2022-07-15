using System.Data;

namespace Domain;
public interface IRepository<T>
{
    IDbConnection Open();
    Task<IEnumerable<T>> GetAsync();
}