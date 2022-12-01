using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        protected Asset()
        {
            Id = -1;
            Name = "";
            Manufacturer = "";
        }

        protected Asset(int id, string name, string manufacturer)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
        }

        public abstract void RetrieveData();
    }
}
