using System.ComponentModel.DataAnnotations;

namespace PersonInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string firstName;

        public string FirstName
        {
            get => firstName;
            private set
            {
                if (value.Length > 3)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
        }

        private string lastName;

        public string LastName
        {
            get => lastName;
            private set
            {
                if (value.Length > 3)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }

        private int age;

        public int Age
        {
            get => age;
            private set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }

        private decimal salary;

        public decimal Salary
        {
            get => salary;
            private set
            {
                if (value >= 460)
                {
                    salary = value;
                }
                else 
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            }
        }
        
        public Person(string firstName, string lastName, int age,decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary} leva.";
        }
    }
}
