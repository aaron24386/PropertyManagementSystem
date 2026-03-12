using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PropertyManagementSystem
{
    internal class Property : IComparable
    {
        readonly uint id;
        readonly uint x;
        readonly uint y;

        public uint OwnerId { get; set; }

        public string StreetAddr { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public bool ForSale { get; set; }

        public void GetStreetNumberAndName (out int streetNumber, out string streetName)
        {
            Regex regex = new Regex("[0-9]+ ");
            string[] splitAddr = regex.Split(StreetAddr);
            Match match = regex.Match(StreetAddr);
            Int32.TryParse(match.Value.Trim(), out streetNumber);
            if (streetNumber == 0)
            {
                throw new ArgumentException("Street number is not a valid integer.");
            }
            streetName = splitAddr[1];
        }

        public Property()
        {
            id = 0;
            OwnerId = 0;
            StreetAddr = "";
            City = "";
            Zip = "";
            State = "";
            ForSale = false;
        }

        public Property(string[] args)
        {
            uint.TryParse(args[0], out uint currentId);
            id = currentId;

            uint.TryParse(args[1], out uint ownerId);
            OwnerId = ownerId;

            uint.TryParse(args[2], out uint newX);
            uint.TryParse(args[3], out uint newY);
            x = newX;
            y = newY;

            StreetAddr = args[4];
            City = args[5];
            State = args[6];
            Zip = args[7];
            ForSale = args[8] == "T";
        }

        public int CompareTo(object alpha)
        {
            Property property = (Property)alpha;
            property.GetStreetNumberAndName(out int currentStreetNumber, out string currentStreetName);
            this.GetStreetNumberAndName(out int streetNumber, out string streetName);
            string state = property.State;
            string city = property.City;

            int statePos = State.CompareTo(state);
            int cityPos = City.CompareTo(city);
            int streetNamePos = streetName.CompareTo(currentStreetName);
            int streetNumberPos = streetNumber.CompareTo(currentStreetNumber);

            int unitPos = 0;
            if (property is Apartment currentApartment && this is Apartment apartment)
            {
                unitPos = apartment.Unit.CompareTo(currentApartment.Unit);
            }

            if (statePos == 0)
            {
                if (cityPos == 0)
                {
                    if (streetNamePos == 0)
                    {
                        if (streetNumberPos == 0)
                        {
                            return unitPos;
                        }
                        else
                        {
                            return streetNumberPos;
                        }
                    }
                    else
                    {
                        return streetNamePos;
                    }
                }
                else
                {
                    return cityPos;
                }
            }
            else
            {
                return statePos;
            }
        }

    }
}
