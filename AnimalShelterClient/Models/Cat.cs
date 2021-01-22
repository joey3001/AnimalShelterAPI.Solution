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
      List<Cat> catList = JsonConvert.DeserializeObject<List<Cat>>(jsonResponse.ToString());

      return catList;
    }
    public static Cat GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Cat cat = JsonConvert.DeserializeObject<Cat>(jsonResponse.ToString());

      return cat;
    }

    public static void Post(Cat cat)
    {
      string jsonCat = JsonConvert.SerializeObject(cat);
      var apiCallTask = ApiHelper.Post(jsonCat);
    }

    public static void Put(Cat cat)
    {
      string jsonCat = JsonConvert.SerializeObject(Cat);
      var apiCallTask = ApiHelper.Put(Cat.CatId, jsonCat);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}