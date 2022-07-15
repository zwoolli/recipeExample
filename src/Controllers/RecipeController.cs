using Microsoft.AspNetCore.Mvc;
using Domain;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecipeController : ControllerBase
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeController(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    [HttpGet, Produces("application/json")]
    public async Task<ActionResult<IEnumerable<Recipe>>> Get()
    {
        IEnumerable<Recipe> recipes = await _recipeRepository.GetAsync();

        return Ok(recipes.ToList());
    }

    [HttpGet("{name}"), Produces("application/json")]
    public async Task<ActionResult<Recipe>> GetByName(string name)
    {
        // Get recipe by name
        Recipe recipe = await _recipeRepository.GetByNameAsync(name);

        // If empty, return not found
        if (recipe.recipe_id == Guid.Empty)
        {
            return NotFound();
        }

        // Otherwise, return recipe
        return recipe;
    }
}
