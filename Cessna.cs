using System;

namespace garys_wholesale_garage
{
  public class Cessna : Vehicle  // Propellor light aircraft
  {
      public double FuelCapacity { get; set; }

      public void RefuelTank()
      {
          // method definition omitted
      }
      public override void Drive()
      {
        Console.WriteLine("The blue Cessna flies by! Zooooom!");
      }
  }
}