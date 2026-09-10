using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class CategoryController : Controller
{
    private readonly IServiceManager _manager;

    public CategoryController(IServiceManager manager)
    {
        _manager = manager;
    }

    public IActionResult Index()
    {
        var model = _manager.CategoryService.GetAllCategories(false);
        return View(model);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([FromForm] CategoryDtoForInsertion categoryDto)
    {
        if (ModelState.IsValid)
        {
            _manager.CategoryService.CreateCategory(categoryDto);
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Update([FromRoute(Name = "id")] int id)
    {
        var model = _manager.CategoryService.GetOneCategoryForUpdate(id, false);
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Update([FromForm] CategoryDtoForUpdate categoryDto)
    {
        if (ModelState.IsValid)
        {
            _manager.CategoryService.UpdateOneCategory(categoryDto);
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Delete([FromRoute(Name = "id")] int id)
    {
        _manager.CategoryService.DeleteOneCategory(id);
        return RedirectToAction("Index");
    }
}
