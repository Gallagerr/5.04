using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
  class SportCar : Car
  {
    public string Name { get; set; }
    public void StartRide()
    {
      Start(Name, Speed(new Random(), 600, 1000));
    }
  }
}
