using System;

namespace garys_wholesale_garage
{
    class Program
    {
        static void Main(string[] args)
        {
          Zero fxs = new Zero ();
          Tesla modelS = new Tesla ();
          Cessna mx410 = new Cessna ();
          Ram f150 = new Ram ();

          fxs.Drive();
          fxs.Turn("left");
          fxs.Stop();
          Console.WriteLine();

          modelS.Drive();
          modelS.Turn("right");
          modelS.Stop();
          Console.WriteLine();

          mx410.Drive();
          mx410.Turn("up");
          mx410.Stop();
          Console.WriteLine();

          f150.Drive();
          f150.Turn("down");
          f150.Stop();

          
          
          
          
        }
    }
}
