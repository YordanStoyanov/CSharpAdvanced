using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;
        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public List<Employee> Data { get; set; }
        public int Count { get; }

        public void Add(Employee employee)
        {
            if (this.data.Count < Capacity)
            {
                this.data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);
            if (employee == null)
            {
                return false;
            }
            data.Remove(employee);
            return true;
        }

        public Employee GetOldestEmployee()
        {
            Employee employee = data.OrderByDescending(e => e.Age).FirstOrDefault();
            return employee;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);
            return employee;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var employee in data)
            {
                sb.AppendLine($"Employee: {employee.Name}, {employee.Age} ({employee.Country})");
            }

            return sb.ToString();
        }
    }
}
