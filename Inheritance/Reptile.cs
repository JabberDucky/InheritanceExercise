using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public bool CanSwim { get; set; }
        public bool HasScales { get; set; }
        public string LayEggs { get; set; }
        public string HaveVertebrates { get; set; }
    }
}
