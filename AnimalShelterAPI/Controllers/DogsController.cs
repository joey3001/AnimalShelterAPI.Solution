using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterAPI.Models; 

namespace AnimalShelterAPI.Controllers 
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private AnimalShelterAPIContext _db;
    public DogsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }

    // GET api/dogs
    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get(int dogId, int age, string name, string breed)
    {
      var query = _db.Dogs.AsQueryable();

      if (dogId != 0)
      {
        query = query.Where(entry => entry.DogId == dogId);
      }

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Dog> Get(int id)
    {
      return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
    }

    // POST api/dogs
    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }

    // PUT api/dogs/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Dog dog)
    {
      dog.DogId = id;
      _db.Entry(dog).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
      _db.Dogs.Remove(dogToDelete);
      _db.SaveChanges();
    }
  }
}