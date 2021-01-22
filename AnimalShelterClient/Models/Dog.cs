using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public static List<Dog> GetDogs()
    {
      var apiCallTask = ApiHelper.GetAllDogs();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Animal> dogList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse.ToString());

      return dogList;
    }
  }
}