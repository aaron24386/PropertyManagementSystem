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
        static string[] quitOptions = new string[] { "q", "e", "quit", "exit" };
        static Community community = new Community();
        static void Main(string[] args)
        {
            AddResidents();
            AddProperties();

            DisplayOptions();


            bool shouldContinue = true;
            while (shouldContinue)
            {
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out int validInput))
                {
                    shouldContinue = ExecuteAction(validInput);
                }
                else if (Array.IndexOf(quitOptions, input.ToLower()) != -1)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid option, please try again");
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
            string input = "";
            switch (action)
            {
                case 1:
                    community.DisplayPropertyList();
                    break;
                case 2:
                    DetermineAddressType();
                    break;
                case 3:
                    community.DisplayForSaleProperties();
                    break;
                case 4:
                    community.DisplayAllResidents();
                    break;
                case 5:
                    input = CollectAddressName();
                    community.DisplayResidentsByAddress(input);
                    break;
                case 6:
                    input = CollectAddressName();
                    community.ToggleForSaleStatus(input);
                    break;
                case 7:
                    input = CollectAddressName();
                    community.PurchaseProperty(input);
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
                community.AddResident(new Person(person));
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
                        community.AddProperty(new Apartment(property));
                    }
                    else
                    {
                        community.AddProperty(new House(property));
                    }
                    line = sr.ReadLine();
                }

                sr.Close();
            }
        }
        
        static private void DetermineAddressType()
        {
            string[] validPropertyTypes = new string[] { "apartment", "house" };
            Console.WriteLine("Enter property type (Apartment/House)");

            bool shouldContinue = true;
            while (shouldContinue)
            {
                string input = Console.ReadLine();
                int propertyIndex = Array.IndexOf(validPropertyTypes, input.ToLower());
                if (propertyIndex == -1)
                {
                    Console.WriteLine($"{input} is not a valid option, please try again");
                }
                else if (Array.IndexOf(quitOptions, input.ToLower()) != -1)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    community.DisplayProperties(propertyIndex == 0 ? "Apartment" : "House");
                    shouldContinue = false;
                }
            }
        }

        static private string CollectAddressName()
        {
            Console.WriteLine("Enter street address to lookup:");
            return Console.ReadLine();
        }
    }
}
