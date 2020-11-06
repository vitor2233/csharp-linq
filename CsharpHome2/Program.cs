using System;
using System.Collections.Generic;

namespace CsharpHome2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.loadSampleData();
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearsExperience }");
            }
        }
    }
}
