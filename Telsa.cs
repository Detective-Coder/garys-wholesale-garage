using System;

namespace garys_wholesale_garage
  {
  public class Tesla : Vehicle // Electric car
  {
      public double BatteryKWh { get; set; }

      public void ChargeBattery()
      {
          // method definition omitted
      }
      public override void Drive()
      {
        Console.WriteLine("The red Tesla slips by! Buzzzzzz!");
      }
  }
}