using System;

namespace garys_wholesale_garage
  {
  public class Ram : Vehicle  // Gas powered truck
  {
      public double FuelCapacity { get; set; }

      public void RefuelTank()
      {
          // method definition omitted
      }
      public override void Drive()
      {
        Console.WriteLine("The black Ram barrels by! Rabbblllee!");
      }
  }
}