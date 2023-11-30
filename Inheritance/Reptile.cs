using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public int NumberOfScales { get; set; }

        public bool HasWebbedFeet { get; set; }

        public bool CanCamoflauge { get; set; }

        public bool IsAquatic { get; set; }
    }
}   
