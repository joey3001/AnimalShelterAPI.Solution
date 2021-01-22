using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterAPI.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
  }
}