using BicAuto.Models;
namespace BicAuto.ViewModels;

public class AutoListViewModel
{ 
    public IEnumerable<Auto> Autos { get; }
    public string? CurrentCategory { get; }
    public AutoListViewModel(IEnumerable<Auto> 
        autos, string? currentCategory)
    {
        Autos = autos;
        CurrentCategory= currentCategory;
    }
}
