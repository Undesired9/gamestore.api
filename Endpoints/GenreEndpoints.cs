using Gamestore.api.Data;
using Gamestore.api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Gamestore.api.Endpoints
{
    public static class GenreEndpoints
    {
        public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("genres");

            group.MapGet("/", async (GameStoreContext dbContext) =>
            await dbContext.Genres
                              .Select(genre=> genre.toDto())
                              .AsNoTracking()
                              .ToListAsync());

            return group;
        }
    }
}
