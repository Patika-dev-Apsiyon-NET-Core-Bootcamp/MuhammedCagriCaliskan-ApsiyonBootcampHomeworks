using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_Hw4.Models
{
    public class Menu : Entity
    {
        public Store Store { get; set; }
        public int StoreId { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
