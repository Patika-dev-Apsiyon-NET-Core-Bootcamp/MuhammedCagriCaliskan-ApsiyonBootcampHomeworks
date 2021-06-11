using System.Collections.Generic;

namespace Bootcamp_Hw4.Models
{
    public class Category : Entity
    {
        public ICollection<Product> Products { get; set; }
        public ICollection<Store> Stores { get; set; }
        
    }
}
