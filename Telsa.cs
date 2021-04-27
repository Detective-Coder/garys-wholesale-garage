using System;

namespace garys_wholesale_garage
  {
  public class Tesla : Vehicle, IElectricVehicle  // Electric car
  {
      public double BatteryKWh { get; set; }

      public override void Drive()
      {
        Console.WriteLine("The red Tesla slips by! Buzzzzzz!");
      }
      
      public int CurrentChargePercentage {get; set;}
      public void ChargeBattery()
      {
          CurrentChargePercentage = 100;
      }
  }
}