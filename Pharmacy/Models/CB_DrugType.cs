using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    class CB_DrugType:DrugType
    {
        //public int Id { get; set; }
        //public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
