using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem
{
    internal class Apartment : Residential
    {
        public string Unit { get; set; }

        public Apartment() : base()
        {
            Unit = "";
        }

        public Apartment(string[] args) : base(args)
        {
            Unit = args[12];
        }
    }
}
