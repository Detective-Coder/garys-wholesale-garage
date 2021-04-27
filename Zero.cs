using System;

namespace garys_wholesale_garage
{
  public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
  {
      public double BatteryKWh { get; set; }

      public override void Drive()
      {
        Console.WriteLine("The silver Zero zips by! Shookaaaaa!");
      }
      public override void Stop()
      {
        Console.WriteLine("The silver Zero zips by! Shookaaaaa!");
      }
      public int CurrentChargePercentage {get; set;}
      public void ChargeBattery()
      {
          CurrentChargePercentage = 100;
      }
  }
}