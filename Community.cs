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

        public void AddResident (Person person)
        {
            Residents.Add(person);
        }

        public void AddProperty (Property property)
        {
            bool wasAdded = Props.Add(property);
            if (!wasAdded)
            {
                throw new Exception("Failed to add new property");
            }
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

            LogProperties(Props);
        }

        public void DisplayProperties (string propertyType)
        {
            Console.WriteLine($"List of addresses of {propertyType} properties in the {this.name} community.");
            Console.WriteLine("-----------------------------------------------------------------------\n");

            IEnumerable<Property> residences = GetProperties(propertyType);
            foreach (Property residence in residences)
            {
                string unitText = " ";
                if (residence is Apartment apartment)
                {
                    unitText = $" Apt.# {apartment.Unit} ";

                }
                Console.WriteLine($"{residence.StreetAddr}{unitText}{residence.City}, {residence.State}, {residence.Zip}\n");
            }
        }

        public void DisplayForSaleProperties ()
        {
            Console.WriteLine($"List of addresses for all FOR SALE properties in the {this.name} community.");
            Console.WriteLine("-----------------------------------------------------------------------\n");

            IEnumerable<Property> forSaleProperties = GetForSaleProperties();

            foreach (Property forSaleProperty in forSaleProperties)
            {
                string unitInfo = " ";
                if (forSaleProperty is Apartment apartment)
                {
                    unitInfo = $" Apt.# {apartment.Unit} ";
                }

                Console.WriteLine($"{forSaleProperty.StreetAddr}{unitInfo}{forSaleProperty.City}, {forSaleProperty.State}, {forSaleProperty.Zip}");
            }
        }

        public void DisplayAllResidents ()
        {
            Console.WriteLine($"List of all residents in the {this.name} community.");
            Console.WriteLine("-----------------------------------------------------------------------\n");

            LogResidents(Residents);
        }

        public void DisplayResidentsByAddress (string addressName)
        {
            IEnumerable<Property> properties = GetPropertiesByName(addressName);
            IEnumerable<uint> ownerIds = properties.Select(property => property.OwnerId);

            if (properties.Count() > 0)
            {
                Console.WriteLine($"List of residents living at {addressName}:");
                Console.WriteLine("-----------------------------------------------------------------------\n");

                
                IEnumerable<Person> residents = FindResidents(ownerIds);

                LogResidents(residents);
            }
            else
            {
                Console.WriteLine($"{addressName} does not exist in the community");
            }
        }

        public void ToggleForSaleStatus (string addressName)
        {
            Property property = GetPropertyByName(addressName);

            if (property != null)
            {
                property.ForSale = !property.ForSale;
                string forSaleText = property.ForSale ? "for sale" : "NOT for sale";

                Console.WriteLine($"{addressName} is now listed as {forSaleText}!\n");
            }
            else
            {
                Console.WriteLine($"{addressName} does not exist in the community");
            }
        }

        public void PurchaseProperty (string addressName)
        {
            Property property = GetPropertyByName(addressName);

            if (property == null)
            {
                Console.WriteLine($"{addressName} does not exist in the community");
            }
            else if (property.ForSale)
            {
                property.ForSale = false;

                Console.WriteLine($"Congratulations! You have successfully purchased this property!\n");
                LogProperties(new[] { property });
            }
            else
            {
                Console.WriteLine($"{addressName} is not for sale.");
            }
        }

        private Person FindResident (uint ownerId)
        {
            return Residents.FirstOrDefault(resident => resident.id == ownerId);
        }

        private IEnumerable<Person> FindResidents (IEnumerable<uint> ownerIds)
        {
            return Residents.Where(resident => ownerIds.Contains(resident.id));
        }

        private IEnumerable<Property> GetProperties (string propertyType)
        {
            return Props.Where(property => property.GetType().Name == propertyType);
        }

        private Property GetPropertyByName (string propertyName)
        {
            return Props.FirstOrDefault(property => property.StreetAddr == propertyName);
        }

        private IEnumerable<Property> GetPropertiesByName (string propertyName)
        {
            return Props.Where(property => property.StreetAddr == propertyName);
        }

        private IEnumerable<Property> GetForSaleProperties ()
        {
            return Props.Where(property => property.ForSale);
        }

        private void LogResidents(IEnumerable<Person> residents)
        {
            foreach (Person resident in residents)
            {
                Console.WriteLine($"{resident.FullName}, Age ({resident.GetAge}), Occupation: {resident.Occupation}\n");
            }
        }

        private void LogProperties(IEnumerable<Property> properties)
        {
            foreach (Residential property in properties.Cast<Residential>())
            {
                Person resident = FindResident(property.OwnerId);
                string forSaleText = (property.ForSale) ? "FOR SALE" : "NOT FOR SALE";
                string apartmentText = "";
                string houseText = "";

                if (property is Apartment apartment)
                {
                    apartmentText = $"Apt.# {apartment.Unit}";
                }
                else
                {
                    House house = (House)property;
                    houseText = $"... {house.GarageText()} : {house.Floors.ToString()} floor.\n";
                }

                Console.WriteLine($"Property Address: {property.StreetAddr} / {property.City} / {property.State} / {property.Zip}");
                Console.WriteLine($"\tOwned By {resident.FullName}, Age ({resident.GetAge}), Occupation: {resident.Occupation}");
                Console.WriteLine($"\t({forSaleText}) {property.Bedrooms} bedrooms \\ {property.Baths} baths \\ {property.Sqft} sq. ft. {apartmentText}");
                Console.Write($"\t{houseText}\n");
            }
        }
    }
}
