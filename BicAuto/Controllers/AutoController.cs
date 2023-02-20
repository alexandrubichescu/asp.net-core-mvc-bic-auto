using BicAuto.Repository;
using BicAuto.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BicAuto.Controllers;

public class AutoController : Controller
{
    private readonly IAutoRepository _autoRepository;
    private readonly ICategoryRepository _categoryRepository; 
    public AutoController(IAutoRepository autoRepository, ICategoryRepository categoryRepository)
    {
        _autoRepository = autoRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult List()
    {
        AutoListViewModel autoListViewModel = new 
            (_autoRepository.AllAutos, "Toate autoturismele de vanzare: ");
        return View(autoListViewModel);
    }

    public IActionResult Details(int id)
    {
        var auto = _autoRepository.GetAutoById(id);
        if(auto==null)
            return NotFound();
        return View(auto);  
    }
}

