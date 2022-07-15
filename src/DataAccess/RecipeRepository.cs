using Domain;
using Dapper;
using System.Data;

namespace DataAccess;

public class RecipeRepository : Repository<Recipe>, IRecipeRepository
{
    public RecipeRepository(IDbConfiguration dbConfig) : base(dbConfig) {}

    public override async Task<IEnumerable<Recipe>> GetAsync()
    {
        string sql = $@"
                        SELECT  *
                        FROM    {nameof(Recipe)}";

        using (IDbConnection connection = Open())
        {
            return await connection.QueryAsync<Recipe>(sql);
        }
    }

    public async Task<Recipe> GetByNameAsync(string name)
    {
        string sql = $@"
                        SELECT  *
                        FROM    {nameof(Recipe)}
                        WHERE   {nameof(Recipe)}.{nameof(Recipe.name)} = @{nameof(name)}";
        
        using (IDbConnection connection = Open())
        {
            IEnumerable<Recipe> recipes = await connection.QueryAsync<Recipe>(sql, new {name});

            return recipes.DefaultIfEmpty(new Recipe()).First();
        }
    }


}