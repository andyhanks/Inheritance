namespace Garage
{
      public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

                         public string MainColor = "Midnight Blue";
                          public override void Drive()
                {
            Console.WriteLine($"The {MainColor} Zero Zips by!");
          
                }
           
    }
}