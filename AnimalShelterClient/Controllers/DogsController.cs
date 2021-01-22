using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CretaceousClient.Models;


namespace AnimalShelterClient.Controllers
{
  public class DogsController : Controller 
  {
    public IActionResult Index()
    {
      var dogs = Dog.GetDogs(); 
      return view(dogs); 
    }

    public IActionResult Details(int id)
    {
      var dog = Dog.GetDetails(id);
      return View(dog);
    }

    public IActionResult Edit(int id)
    {
      var dog = Dog.GetDetails(id);
      return View(dog);
    }

    [HttpPost]
    public IActionResult Details(int id, Dog dog)
    {
      dog.DogId = id;
      Dog.Put(dog);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Dog.Delete(id);
      return RedirectToAction("Index");
    }
  }
}