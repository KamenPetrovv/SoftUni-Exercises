
namespace FirstAndReserveTeam
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using PersonInfo;

    public class Team
    {
        private string name { get; set; }

        public string Name
        {
            get => name;
            set => this.name = value;
        }

        private List<Person> firstTeam;

        public List<Person> FirstTeam
        {
            get => new List<Person>(this.firstTeam);
        }

        private List<Person> reserveTeam;

        public List<Person> ReserveTeam
        {
            get => new List<Person>(this.reserveTeam);
        }

        public Team(string name)
        {
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();

            this.Name = name;
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }
}
