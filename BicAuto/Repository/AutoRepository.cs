using BicAuto.Models;
using Microsoft.EntityFrameworkCore;

namespace BicAuto.Repository;

public class AutoRepository : IAutoRepository
{
    private readonly BicAutoDbContext _bicAutoDbContext;

    public AutoRepository(BicAutoDbContext bicAutoDbContext)
    {
        _bicAutoDbContext = bicAutoDbContext;
    }

    public IEnumerable<Auto> AllAutos
    {
        get
        {
            return _bicAutoDbContext.Autos
                .Include(c => c.Category);
        }
    }

    public IEnumerable<Auto> AutosOfTheYear
    {
        get
        {
            return _bicAutoDbContext.Autos
                .Include(c => c.Category)
                .Where(a => a.IsAutoOfTheYear);
        }

    }
    public Auto? GetAutoById(int autoId)
    {
        return _bicAutoDbContext.Autos.FirstOrDefault(a => a.AutoId == autoId);
    }
}

