using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem
{
    internal class Person : IComparable
    {
        private static uint nextId = 1;

        public readonly uint id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{LastName}, {FirstName}";
        public string Occupation { get; set; }
        public string GetAge
        {
            get
            {
                TimeSpan timeDifference = DateTime.Now - birthday;
                double age = Math.Round(timeDifference.TotalDays / 365);
                return age.ToString();
            }

        }

        readonly DateTime birthday;
        private List<int> residenceIds = new List<int>();
        public int[] ResidenceIds {
            get
            {
                return residenceIds.ToArray();
            }
        }

        public Person ()
        {
            id = nextId;
            FirstName = "";
            LastName = "";
            Occupation = "";
            birthday = DateTime.Now;
            residenceIds = new List<int>();

            IncrementNextId();
        }

        public Person (string[] args)
        {
            if (UInt32.TryParse(args[0], out uint newId))
            {
                id = newId;
            }

            LastName = args[1];
            FirstName = args[2];
            Occupation = args[3];

            Int32.TryParse(args[4], out int year);
            Int32.TryParse(args[5], out int month);
            Int32.TryParse(args[6], out int day);
            DateTime newBirthday = new DateTime(year, month, day);
            birthday = newBirthday;


            Int32.TryParse(args[7], out int residenceId);
            residenceIds.Add(residenceId);
            //IncrementNextId();
        }

        public int CompareTo (object alpha)
        {
            Person person = (Person)alpha;
            if (person.FullName is string tempFullName)
            {
                return FullName.CompareTo(tempFullName);
            }

            throw new ArgumentException("Invalid type");
        }

        private void IncrementNextId ()
        {
            nextId++;
        }
    }
}
