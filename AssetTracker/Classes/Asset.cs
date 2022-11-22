using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Asset
    {
        public abstract string Name { get; set; }
        public abstract string Manufacturer { get; set; }

        public abstract void RetrieveData();
    }
}
