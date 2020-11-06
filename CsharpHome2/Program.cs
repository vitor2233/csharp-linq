using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpHome2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.loadSampleData();

            //OrderBy
            //people = people.OrderBy(x => x.FirstName).ToList();
            //people = people.OrderByDescending(x => x.FirstName).ToList();
            //people = people.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.YearsExperience).ToList();

            //Where
            //people = people.Where(x => x.YearsExperience < 5).ToList();
            //people = people.Where(x => x.YearsExperience < 5 && x.Birthday.Month == 3).ToList();

            //Sum
            //int yearsTotal = people.Sum(x => x.YearsExperience);
            //int yearsTotal = 0;
            //Pegue as pessoas com mês igual a 3, depois some YearsExperience
            //yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience);

            //Testes
            //people = people.OrderBy(x => x.Birthday.Year)
            //    .ThenBy(x => x.Birthday.Month).ThenBy(x => x.Birthday.Day).ToList();

            people = people.Where(x => x.FirstName.StartsWith("A")).OrderBy(x => x.FirstName).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearsExperience }");
            }
        }
    }
}
