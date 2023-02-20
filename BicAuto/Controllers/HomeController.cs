using BicAuto.Repository;
using BicAuto.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BicAuto.Controllers;

public class HomeController : Controller
{
    private readonly IAutoRepository _autoRepository;

    public HomeController(IAutoRepository autoRepository)
    {
        _autoRepository = autoRepository;
    }

    public IActionResult Index()
    {
        var autosOfTheYear = _autoRepository.AutosOfTheYear;
        var homeViewModel = new HomeViewModel(autosOfTheYear);
        return View(homeViewModel);
    }
}

