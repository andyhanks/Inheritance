using System.Collections.Specialized;

namespace Garage
{
      public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
          public string MainColor = "White";

          public override void Drive(){
            Console.WriteLine($"The {MainColor} Cessna Zooms");
         }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna coasts a mile down the runway to stop.");
        }

                public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna Rolls {direction}");
        }

    }   
}