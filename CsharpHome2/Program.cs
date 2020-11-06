﻿using System;
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

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearsExperience }");
            }
        }
    }
}
