namespace Garage
{
         public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

                 public string MainColor = "Grey";
                  public override void Drive()
                {
            Console.WriteLine($"The {MainColor} Tesla Speeds dangerously by...");
          
                }
           

    }
}