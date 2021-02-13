using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;
        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }
        public int Capacity { get; private set; }
        public List<Pet> Data { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Pet pet)
        {
            if (this.data.Count < Capacity)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name);
            if (pet == null)
            {
                return false;
            }

            data.Remove(pet);
            return true;
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name && p.Owner == owner);
            return pet;
        }

        public Pet GetOldestPet()
        {
            return data.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("The clinic has the following patients:");
            foreach (var pet in data)
            {
                result.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return result.ToString();
        }
    }
}
