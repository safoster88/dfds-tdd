using Microsoft.EntityFrameworkCore;

namespace Dfds.Recipe.Service
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions options) : base(options) { }
    }
}
