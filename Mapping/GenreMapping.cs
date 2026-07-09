using Gamestore.api.Dtos;
using Gamestore.api.Entities;

namespace Gamestore.api.Mapping;

public static class GenreMapping
{
    public static GenreDto toDto(this Genre genre)
    {
        return new GenreDto(genre.Id, genre.Name);
    }
}
