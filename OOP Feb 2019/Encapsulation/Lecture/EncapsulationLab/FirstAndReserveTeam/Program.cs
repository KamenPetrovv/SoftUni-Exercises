

using System.Runtime.InteropServices;

namespace FirstAndReserveTeam
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

            List<Person> people = new List<Person>();

            //Parse the input data into the collection
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                Person person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));
                people.Add(person);
            }

            //Create a team and test
            Team team = new Team("Bulgaria");

            foreach (Person person in people)
            {
                team.AddPlayer(person);
            }

            //Print results
            Console.WriteLine();
            Console.WriteLine("First team:");
            team.FirstTeam.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();
            Console.WriteLine("Reserve team:");
            team.ReserveTeam.ForEach(p => Console.WriteLine(p));
        }
    }
}
