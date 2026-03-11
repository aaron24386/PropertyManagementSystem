using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem
{
    internal class Program
    {
        static Community community = new Community();
        static void Main(string[] args)
        {
            AddResidents();
            AddProperties();

            DisplayOptions();

            string input = Console.ReadLine();
            string[] quitOptions = new string[] { "q", "e", "quit", "exit" };

            bool shouldContinue = true;
            while (shouldContinue)
            {
                if (Int32.TryParse(input, out int validInput))
                {
                    shouldContinue = ExecuteAction(validInput);
                }
                else if (Array.IndexOf(quitOptions, input.ToLower()) != -1)
                {
                    Console.WriteLine("Exiting...");
                    shouldContinue = false;
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid option, please try again");
                    input = Console.ReadLine();
                }
            }
        }

        static private void DisplayOptions()
        {
            Console.WriteLine("1. Full property list");
            Console.WriteLine("2. List addresses of either House or Apartment-type properties");
            Console.WriteLine("3. List addresses of all for-sale properties");
            Console.WriteLine("4. List all residents of a community");
            Console.WriteLine("5. List all residents of a property, by street address");
            Console.WriteLine("6. Toggle a property, by street address, as being for-sale or not.");
            Console.WriteLine("7. Buy a for-sale property, by street address");
            Console.WriteLine("8. Add yourself as an occupant to a property.");
            Console.WriteLine("9. Remove yourself as an occupant from a property");
            Console.WriteLine("10. Quit");
        }

        static private bool ExecuteAction(int action)
        {
            bool returnVal = true;
            switch (action)
            {
                case 1:
                    community.DisplayPropertyList();
                    break;
                case 2:
                    Console.WriteLine("Enter property type (Apartment/House)");
                    Console.ReadLine();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    Console.WriteLine($"{action} is an invalid action, please try again.");
                    returnVal = false;
                    break;
            }

            return returnVal;
        }
        static private void AddResidents()
        {
            StreamReader sr = new StreamReader("../../p.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] person = line.Split('\t');
                community.addResident(new Person(person));
                line = sr.ReadLine();
            }

            sr.Close();
        }

        static private void AddProperties()
        {
            string[] propertyFiles = new string[] { "../../a.txt", "../../r.txt" };

            StreamReader sr;
            string line;
            for (int i = 0; i < propertyFiles.Length; i++)
            {
                string filePath = propertyFiles[i];
                sr = new StreamReader(filePath);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] property = line.Split('\t');
                    if (i == 0)
                    {
                        community.addProperty(new Apartment(property));
                    }
                    else
                    {
                        community.addProperty(new House(property));
                    }
                    line = sr.ReadLine();
                }

                sr.Close();
            }
        }
        
    }
}
