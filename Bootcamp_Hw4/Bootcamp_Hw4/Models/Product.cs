
namespace Bootcamp_Hw4.Models
{
    public class Product : Entity
    {
        public int Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Menu Menu { get; set; }
        public int MenuId { get; set; }

    }
}
