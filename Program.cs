using System;

namespace StudentCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student()
                {
                    StudentName = "John Smith",
                    DateOfBirth = new DateTime(2000, 5, 10)
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.ReadKey();
            }
        }
    }
}
