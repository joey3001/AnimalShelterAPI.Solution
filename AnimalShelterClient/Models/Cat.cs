using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public static List<Cat> GetCats()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Animal> catList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse.ToString());

      return catList;
    }
  }
}