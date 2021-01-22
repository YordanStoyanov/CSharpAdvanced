using System;

namespace SoftUniParking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Console.WriteLine(car.ToString());
            //Make: Skoda
            //Model: Fabia
            //HorsePower: 65
            //RegistrationNumber: CC1856BG

            Parking parking = new Parking("SoftUniParking", 5);
            //Successfully added new car Skoda CC1856BG
            parking.AddCar(car);
            parking.AddCar(car2);
            
            //Successfully added new car Audi EB8787MN
            parking.GetCar("EB8787MN");
            //Make: Audi
            //Model: A3
            //HorsePower: 110
            //RegistrationNumber: EB8787MN
            parking.RemoveCar("EB8787MN");
            //Successfullyremoved EB8787MN

        }
    }
}
