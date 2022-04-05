using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using afternoonChallengeV2040522.Models;

namespace afternoonChallengeV2040522.Controllers.DB
{
  public class FakeDb
  {
    public static List<Car> Cars { get; set; } = new List<Car>(){
            new Car("Batmobile", "black", 2004),
            new Car("Patty-Wagon", "White", 1999),
            new Car("Leanmobie", "purple", 2002),
            new Car("Badillac", "orange", 2022)
        };
  }
}