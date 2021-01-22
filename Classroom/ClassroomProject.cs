using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count { get; set; }

        public void RegisterStudent(Student student)
        {
            if (students.Count <= Capacity)
            {
                students.Add(student);
                Console.WriteLine($"Added student {student.FirstName} {student.LastName}");
            }
            else
            {
                Console.WriteLine("No seats in the classroom");
            }
        }
        public bool DismissStudent(Student student, string firstName, string lastName)
        {
            Student studentToRemove = students.FirstOrDefault(
                s => s.FirstName == firstName 
            && s.LastName == lastName);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                return true;
            }
            else
            {
                Console.WriteLine("Student not found");
            }
            return false;
        }

        public string GetSubjectInfo(string subject, string firstName, string lastName)
        {
            if (students.Count() != 0)
            {
                return $"Subject: {subject} Students: {firstName} {lastName} ";
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }
        
        public void GetStudent(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
