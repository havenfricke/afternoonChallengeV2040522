using afternoonChallengeV2040522.Controllers.DB;
using afternoonChallengeV2040522.Models;

namespace afternoonChallengeV2040522.Controllers
{
  public class CarsService
  {
    internal List<Car> GetAll()
    {
      return FakeDb.Cars;
    }

    internal Car GetById(string id)
    {
      Car found = FakeDb.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid id");
      }
      return found;
    }

    internal Car Create(Car newCar)
    {
      FakeDb.Cars.Add(newCar);
      return newCar;
    }

    internal Car Update(Car updates)
    {
      Car original = GetById(updates.Id);
      original.Name = updates.Name ?? original.Name;
      original.Color = updates.Color ?? original.Color;
      original.Year = updates.Year ?? original.Year;
      return original;
    }

    internal void Delete(string id)
    {
      Car found = GetById(id);
      FakeDb.Cars.Remove(found);
    }
  }
}