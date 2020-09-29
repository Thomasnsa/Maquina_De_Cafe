using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Virtual.Model
{
    class CafeModel
    {
        public bool moeda1Real { get; set; }
        public bool moeda50Centavos { get; set; }
        public bool moeda25Centavos { get; set; }
        public bool moeda10Centavos { get; set; }
        

        public decimal quantidade1Real { get; set; }
        public decimal quantidade50Centavos { get; set; }
        public decimal quantidade25Centavos { get; set; }
        public decimal quantidade10Centavos { get; set; }
        public decimal quantidade5Centavos { get; set; }
        public decimal quantidade1Centavo { get; set; }

        public bool cafe { get; set; }
        public bool cafeComLeite { get; set; }
        public bool cappuccino { get; set; }
        public bool mocha { get; set; }

        public decimal total { get; set; }
        public decimal troco { get; set; }
    }
}
