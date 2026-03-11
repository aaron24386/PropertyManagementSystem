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
            Garage = args[12] == "T";
            AttachedGarage = args[13] == "T";

            uint.TryParse(args[14], out uint floors);
            Floors = floors; 
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
