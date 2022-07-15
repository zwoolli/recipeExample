namespace Domain;

public interface IRecipeRepository : IRepository<Recipe>
{
    Task<Recipe> GetByNameAsync(string name);
}