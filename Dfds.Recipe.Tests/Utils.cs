using Dfds.Recipe.Service;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dfds.Recipe.Tests
{
    public static class Utils
    {
        public static RecipeContext GetNewInMemoryContextInstance()
        {
            var optionsBuilder = new DbContextOptionsBuilder<RecipeContext>();
            optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            var context = new RecipeContext(optionsBuilder.Options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            return context;
        }
    }
}
