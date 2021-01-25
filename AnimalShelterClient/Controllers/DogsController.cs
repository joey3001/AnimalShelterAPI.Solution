using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterClient.Models; 

namespace AnimalShelterClient.Controllers
{
  public class DogsController : Controller 
  {
    public IActionResult Index()
    {
      var dogs = Dog.GetDogs(); 
      return View(dogs); 
    }

    [HttpPost]
    public IActionResult Index(Dog dog)
    {
      Dog.PostDog(dog);
      return RedirectToAction("Index");
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
      Dog.PutDog(dog);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Dog.DeleteDog(id);
      return RedirectToAction("Index");
    }
  }
}