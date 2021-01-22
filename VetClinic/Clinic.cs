using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VetClinic
{
    public class Clinic
    {
        private int capacity;
        private List<Pet> data;

        public Clinic(int capasity)
        {
            this.Capacity = capasity;
            data = new List<Pet>();
        }

        public int Capacity { get; set; }

        public void Add(Pet pet)
        {
            data.Add(pet);
        }

        public bool Remove(string name)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name);
            if (pet != null)
            {
                data.Remove(pet);
                return true;
            }
            return false;
        }

        public void GetPet(string name, string owner)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name && p.Owner == owner);
        }

        public void GetOldestPet(int age)
        {
            Pet pet = data.FirstOrDefault(p => p.Age == age);

        }
        
    }
}
