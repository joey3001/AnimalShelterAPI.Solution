using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CretaceousClient.Models;


namespace AnimalShelterClient.Controllers
{
  public class CatsController : Controller 
  {
    public IActionResult Index()
    {
      var cats = Cat.GetCats(); 
      return view(cats); 
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
      Cat.Put(cat);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Cat.Delete(id);
      return RedirectToAction("Index");
    }
  }
}