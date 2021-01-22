using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private string type;
        private int capacity;
        private List<Car> data;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Parking()
        {

        }

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            data = new List<Car>(capacity);
        }

        public void AddCar(Car car)
        {
            
            data.Add(car);
            Console.WriteLine($"Successfully added new car {car.Make} {car.RegistrationNumber}");
        }
        public void GetCar(string registrationNumber)
        {
            Car getCar = data.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (getCar != null)
            {
                data.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
                Console.WriteLine("Car with that registration number, already exists!");
            }
            
        }
        
        public bool RemoveCar(string registrationNumber)
        {
            Car carToRemove = data.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (carToRemove != null)
            {
                data.Remove(carToRemove);
                Console.WriteLine($"Successfully removed!");
                return true;
            }
            else
            {
                Console.WriteLine("Car with that registration number, doesn't exist!");
            }

            return false;
        }
    }
}
