using BicAuto.Models;

namespace BicAuto.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly BicAutoDbContext _bicAutoDbContext;

    public CategoryRepository(BicAutoDbContext bicAutoDbContext)
    {
        _bicAutoDbContext = bicAutoDbContext;
    }
    public IEnumerable<Category> AllCategories => _bicAutoDbContext.Categories.OrderBy(a => a.CategoryName);
}

