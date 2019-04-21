
using System.Linq;
using System.Runtime.InteropServices;
using PersonInfo;
namespace SortPeopleByNameAndAge
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static void Main()
        {
            //Read the amount of people inputted
            var lines = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            //Parse the input from the console to the list of people
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                //I guess we assume the input is correct.
                Person person = new Person(cmdArgs[0],cmdArgs[1],int.Parse(cmdArgs[2]),0);
                people.Add(person);
            }

            people.OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName)
                .ToList()
                .ForEach(p => Console.WriteLine(p));

        }
    }
}
