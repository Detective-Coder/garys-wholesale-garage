using System;

namespace garys_wholesale_garage
  {
  public class Ram : Vehicle, IGasVehicle // Gas powered truck
  {
      public double FuelCapacity { get; set; }

      public override void Drive()
      {
        Console.WriteLine("The black Ram barrels by! Rabbblllee!");
      }
      public int CurrentTankPercentage { get; set;} 
      public void RefuelTank() {
        CurrentTankPercentage = 100;
      }
  }
}