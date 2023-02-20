using BicAuto.Models;

namespace BicAuto.Repository;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; }
}

