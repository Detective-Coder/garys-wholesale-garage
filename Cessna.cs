using System;

namespace garys_wholesale_garage
{
  public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
  {
      public double FuelCapacity { get; set; }

      public override void Drive()
      {
        Console.WriteLine("The blue Cessna flies by! Zooooom!");
      }
      public override void Stop()
      {
        Console.WriteLine("The blue Cessna comes to a swift stop");
      }
      public int CurrentTankPercentage { get; set;} 
      public void RefuelTank() {
        CurrentTankPercentage = 100;
      }
   
  }
}