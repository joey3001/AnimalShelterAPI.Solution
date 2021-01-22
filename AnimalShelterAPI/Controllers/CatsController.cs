using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterAPI.Models; 

namespace AnimalShelterAPI.Controllers 
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private AnimalShelterAPIContext _db;
    public CatsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }

    // GET api/cats
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get(int catId, int age, string name, string type)
    {
      var query = _db.Cats.AsQueryable();

      if (catId != 0)
      {
        query = query.Where(entry => entry.CatId == catId);
      }

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
    }
    
    // POST api/cats
    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    // PUT api/cats/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Cat cat)
    {
      cat.CatId = id;
      _db.Entry(cat).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }
}