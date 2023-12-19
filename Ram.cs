namespace Garage
{
      public class Ram : Vehicle // Truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

            public string MainColor = "Red";
          public override void Drive(){
            Console.WriteLine($"The {MainColor} Ram chugs obnoxiously by");
           }
           
    }   
}