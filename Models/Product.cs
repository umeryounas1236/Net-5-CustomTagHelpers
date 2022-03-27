using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net_5_CustomTagHelpers.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int CategoryId { get; set; }

    }
}
