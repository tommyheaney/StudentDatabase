using System;
using StudentDatabase.Models;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Add a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 1, 1)
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully.");
            }
        }
    }
}
