using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    public class StartUp
    {
        public static void Main()
        {
            // Initialize the repository
            Classroom classroom = new Classroom(10);
            // Initialize entities
            Student student = new Student("Peter", "Parker", "Geometry");
            Student studentTwo = new Student("Sarah", "Smith", "Algebra");
            Student studentThree = new Student("Sam", "Winchester", "Algebra");
            Student studentFour = new Student("Dean", "Winchester", "Music");
            // Print Student
            Console.WriteLine(student); // Student: First Name = Peter, Last Name = Parker, Subject = Geometry
                                        // Register Student
            
            classroom.RegisterStudent(student);
             // Added student Peter Parker
            classroom.RegisterStudent(studentTwo);
            classroom.RegisterStudent(studentThree);
            classroom.RegisterStudent(studentFour);
            // Dismiss Student
            classroom.DismissStudent(null, "Peter", "Parker");
            
            classroom.DismissStudent(null, "Ellie", "Goulding");
            // Student not found
                                             // Subject info
            classroom.GetSubjectInfo(null, "Algebra", null);
            
            // Subject: Algebra
            // Students:
            // Sarah Smith
            // Sam Winchester
            classroom.GetSubjectInfo("Art", null, null);
            // No students enrolled for the subject
                                            // Get Student
            //Console.WriteLine(classroom.GetStudent("Dean", "Winchester"));
            // Student: First Name = Dean, Last Name = Winchester, Subject = Music

        }
    }
}
