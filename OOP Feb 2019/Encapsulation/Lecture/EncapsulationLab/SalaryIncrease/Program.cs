
namespace SalaryIncrease
{
    using System;
    using System.Collections.Generic;
    using PersonInfo;

    class Program
    {
        static void Main(string[] args)
        {
            //Get the amout of people that will be inputted
            int lines = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            //Parse the input data into the collection
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                Person person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            //Increase slaries with a given percentage
            var percentage = decimal.Parse(Console.ReadLine());

            //Print results
            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
