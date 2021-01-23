using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterClient.Models; 

namespace AnimalShelterClient.Controllers
{
  public class CatsController : Controller 
  {
    public IActionResult Index()
    {
      var cats = Cat.GetCats(); 
      return View(cats); 
    }

    public IActionResult Details(int id)
    {
      var cat = Cat.GetDetails(id);
      return View(cat);
    }

    public IActionResult Edit(int id)
    {
      var cat = Cat.GetDetails(id);
      return View(cat);
    }

    [HttpPost]
    public IActionResult Details(int id, Cat cat)
    {
      cat.CatId = id;
      Cat.PutCat(cat);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Cat.DeleteCat(id);
      return RedirectToAction("Index");
    }
  }
}