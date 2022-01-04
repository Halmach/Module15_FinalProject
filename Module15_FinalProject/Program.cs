using System;
using System.Collections.Generic;
using System.Linq;

namespace Module15_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
           var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var result = classes.SelectMany(
             s => s.Students,
             (s, n) => new { Name = n })
             .Select(s => s.Name);

            return result.ToArray();
        }
    }
}
