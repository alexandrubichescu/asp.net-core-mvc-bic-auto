using BicAuto.Models;

namespace BicAuto.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Auto> AutosOfTheYear { get; }
        public HomeViewModel(IEnumerable<Auto> autosOfTheYear)
        {
            AutosOfTheYear = autosOfTheYear;
        }

    }
}
