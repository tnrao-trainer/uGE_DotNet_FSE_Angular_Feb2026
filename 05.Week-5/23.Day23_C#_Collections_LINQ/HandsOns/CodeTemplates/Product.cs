using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class Product
    {
        public int ProCode { get; set; }

        public string ProName { get; set; }

        public string ProCategory { get; set; }

        public double ProMrp { get; set; }

        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{ProCode=1001,ProName="Colgate-100gm",ProCategory="FMCG",ProMrp=55 },
                 new Product{ProCode=1002,ProName="Colgate-50gm",ProCategory="FMCG",ProMrp=30 },
                 new Product{ProCode=1009,ProName="DaburRed-100gm",ProCategory="FMCG",ProMrp=50 },
                 new Product{ProCode=1006,ProName="DaburRed-50gm",ProCategory="FMCG",ProMrp=28 },
                 new Product{ProCode=1008,ProName="Himalaya Neem Face Wash",ProCategory="FMCG",ProMrp=70 },
                 new Product{ProCode=1007,ProName="Niviea Face Wash",ProCategory="FMCG",ProMrp=120 },
                 new Product{ProCode=1010,ProName="Daawat-Basmati",ProCategory="Grain",ProMrp=130 },
                  new Product{ProCode=1011,ProName="Delhi Gate-Basmati",ProCategory="Grain",ProMrp=120 },
                  new Product{ProCode=1014,ProName="Saffola-Oil",ProCategory="Edible-Oil",ProMrp=160 },
                   new Product{ProCode=1016,ProName="Fortune-Oil",ProCategory="Edible-Oil",ProMrp=150 },
                   new Product{ProCode=1018,ProName="Nescafe",ProCategory="FMCG",ProMrp=70 },
                   new Product{ProCode=1019,ProName="Bru",ProCategory="FMCG",ProMrp=90},
                    new Product{ProCode=1015,ProName="Parachut",ProCategory="Edible-Oil",ProMrp=60}
            };
          
        }
    }
}
