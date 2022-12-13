using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Assets
{
    public abstract class Asset
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        protected Asset()
        {
            Name = "";
            Manufacturer = "";
        }

        protected Asset(int id, string name, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }

        public abstract void RetrieveData();
    }
}
