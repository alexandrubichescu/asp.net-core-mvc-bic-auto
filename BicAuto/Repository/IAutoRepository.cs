using BicAuto.Models;

namespace BicAuto.Repository;

public interface IAutoRepository
{
    IEnumerable<Auto> AllAutos { get; }
    IEnumerable<Auto> AutosOfTheYear { get; }
    Auto? GetAutoById(int autoId);
}

