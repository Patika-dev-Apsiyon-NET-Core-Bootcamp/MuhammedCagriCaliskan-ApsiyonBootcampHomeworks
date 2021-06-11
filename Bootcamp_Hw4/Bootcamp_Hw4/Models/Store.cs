
using System.Collections.Generic;

namespace Bootcamp_Hw4.Models
{
    public class Store : Entity
    {
        public string City { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<Category> Categories { get; set; }
        


    }
}
