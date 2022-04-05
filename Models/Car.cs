using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace afternoonChallengeV2040522.Models
{
  public class Car
  {
    public string Id { get; set; }

    [Required]
    [MinLength(3)]
    public string Name { get; set; }

    [Required]
    public string Color { get; set; }

    [Range(1950, 2022)]
    public int? Year { get; set; }

    public Car(string name, string color, int? year)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Color = color;
      Year = year;
    }

  }
}