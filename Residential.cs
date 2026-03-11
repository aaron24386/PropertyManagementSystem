using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagementSystem
{
    internal class Residential : Property
    {
        public uint Bedrooms { get; set; }
        public uint Baths { get; set; }
        public uint Sqft { get; set; }

        public Residential() : base()
        {
            Bedrooms = 0;
            Baths = 0;
            Sqft = 0;
        }

        public Residential(string[] args) : base(args)
        {
            uint.TryParse(args[9], out uint bedrooms);
            Bedrooms = bedrooms;

            uint.TryParse(args[10], out uint baths);
            Baths = baths;

            uint.TryParse(args[11], out uint sqft);
            Sqft = sqft;
        }
    }
}
