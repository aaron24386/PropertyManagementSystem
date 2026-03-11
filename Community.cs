using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem
{
    internal class Community : IComparable, IEnumerable
    {
        public readonly uint id;
        public readonly string name;
        uint MayorId { get; set; }
        public SortedSet<Property> Props { get; }
        public SortedSet<Person> Residents { get; }

        public int Population
        {
            get => Residents.Count;
        }

        public Community ()
        {
            id = 99999;
            MayorId = 0;
            name = "Dekalb";
            Props = new SortedSet<Property>();
            Residents = new SortedSet<Person>();
        }

        public Community (string newName, Property newProperty, Person newResident)
        {
            id = 99999;
            MayorId = 0;
            name = newName ?? "Dekalb";
            Props = new SortedSet<Property>();
            bool isPropertyAdded = Props.Add(newProperty);
            if (!isPropertyAdded)
            {
                throw new ArgumentException("Failed to add the new property");
            }

            Residents = new SortedSet<Person>();
            bool isResidentAdded = Residents.Add(newResident);
            if (!isResidentAdded)
            {
                throw new ArgumentException("Failed to add the new resident");
            }
        }

        public void addResident (Person person)
        {
            Residents.Add(person);
        }
        public void addProperty (Property property)
        {
            Props.Add(property);
        }

        public int CompareTo (object alpha)
        {
            Community community = (Community)alpha;
            if (community.name is string communityName)
            {
                return community.name.CompareTo(communityName);
            }

            throw new ArgumentException("Invalid type");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Residents.GetEnumerator();
        }

        public void DisplayPropertyList()
        {
            Person mayor = FindResident(this.MayorId);
            Console.WriteLine($"<{this.id}> {this.name}. Population ({Residents.Count}). Mayor: {mayor.FullName}");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (Residential property in Props.Cast<Residential>())
            {
                Person resident = FindResident(property.OwnerId);
                string forSaleText = (property.ForSale) ? "FOR SALE" : "NOT FOR SALE";
                string apartmentText = "";
                string houseText = "";
                if (property is Apartment)
                {
                    Apartment apartment = (Apartment)property;
                    apartmentText = $"Apt.# {apartment.Unit}";
                }
                else
                {
                    House house = (House)property;
                    houseText = $"... {house.GarageText()} : {house.Floors.ToString()} floor.";
                }
                Console.WriteLine($"Property Address: {property.StreetAddr} / {property.City} / {property.State} / {property.Zip}");
                Console.WriteLine($"\tOwned By {resident.FullName}, Age ({resident.GetAge}), Occupation: {resident.Occupation}");
                Console.WriteLine($"\t({forSaleText} {property.Bedrooms} bedrooms \\ {property.Baths} baths \\ {property.Sqft} sq. ft. {apartmentText}");
                Console.WriteLine($"\t{houseText}\n");
            }
        }

        private Person FindResident (uint ownerId)
        {
            return Residents.FirstOrDefault(resident => resident.id == ownerId);
        }
    }
}
