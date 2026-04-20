using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem
{
    internal class House : Residential
    {
        public bool Garage { get; set; }
        public Nullable<bool> AttachedGarage { get; set; }
        public uint Floors { get; set; }

        public House() : base()
        {
            Garage = false;
            AttachedGarage = null;
            Floors = 0;
        }

        public House(string[] args) : base(args)
        {
            if (args.Length >= 13)
            {
                Garage = args[12] == "T";
            }
            else
            {
                Garage = false;
            }

            if (args.Length >= 14)
            {
                AttachedGarage = args[13] == "T";
            }
            else
            {
                AttachedGarage = false;
            }

            if (args.Length >= 15)
            {
                uint.TryParse(args[14], out uint floors);
                Floors = floors; 
            }
            else
            {
                Floors = 0;
            }
        }

        public string GarageText()
        {
            string text = "with ";
            if ((bool)AttachedGarage)
            {
                text += "an attached garage";
            }
            else if (Garage)
            {
                text += "a detached garage";
            }
            else
            {
                text += "no garage";
            }

            return text;
        }
    }
}
