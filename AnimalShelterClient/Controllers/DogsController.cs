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
  }
}