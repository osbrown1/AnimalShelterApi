using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiController]
  [ApiVersion("1.0")]
  [ApiVersion("2.0")]
  public class DogsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public DogsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // GET: api/Dogs
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dog>>> Get(string breed, string name, int minimumAge)
    {
      IQueryable<Dog> query = _db.Dogs.AsQueryable();

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (minimumAge > 0)
      {
        query = query.Where(entry => entry.Age >= minimumAge);
      }

      return await query.ToListAsync();
    }

    // GET: api/Dogs/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Dog>> GetDog(int id)
    {
      Dog dog = await _db.Dogs.FindAsync(id);

      if (dog == null)
      {
        return NotFound();
      }

      return dog;
    }

    // POST api/Dogs
    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog dog)
    {
      _db.Dogs.Add(dog);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetDog), new { id = dog.DogId }, dog);
    }

    // PUT: api/Dogs/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Dog dog)
    {
      if (id != dog.DogId)
      {
        return BadRequest();
      }

      _db.Dogs.Update(dog);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool DogExists(int id)
    {
      return _db.Dogs.Any(e => e.DogId == id);
    }

    // DELETE: api/Dogs/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDog(int id)
    {
      Dog dog = await _db.Dogs.FindAsync(id);
      if (dog == null)
      {
        return NotFound();
      }

      _db.Dogs.Remove(dog);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
} 
