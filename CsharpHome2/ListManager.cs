using System;
using System.Collections.Generic;

namespace CsharpHome2
{
    public class ListManager
    {
        public static List<Person> loadSampleData()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person { FirstName = "Vítor", LastName = "Guilherme", Birthday = Convert.ToDateTime("22/3/2001"), YearsExperience = 1 });
            output.Add(new Person { FirstName = "Vítor", LastName = "Pedrosa", Birthday = Convert.ToDateTime("22/3/2001"), YearsExperience = 2 });
            output.Add(new Person { FirstName = "Pedro", LastName = "Henrique", Birthday = Convert.ToDateTime("21/11/2000"), YearsExperience = 1 });
            output.Add(new Person { FirstName = "André", LastName = "Gustavo", Birthday = Convert.ToDateTime("12/12/1980"), YearsExperience = 27 });
            output.Add(new Person { FirstName = "Alisson", LastName = "Pedrosa", Birthday = Convert.ToDateTime("17/2/1999"), YearsExperience = 4 });
            output.Add(new Person { FirstName = "Silvania", LastName = "Moreira", Birthday = Convert.ToDateTime("03/6/1980"), YearsExperience = 10 });
            output.Add(new Person { FirstName = "Ederson", LastName = "Martins", Birthday = Convert.ToDateTime("29/10/1960"), YearsExperience = 20 });

            return output;
        }
    }
}