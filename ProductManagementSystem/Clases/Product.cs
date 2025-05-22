using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{

    public enum ProductCategory
    {
        Electronica,
        Alimentos
        
    }
    public class Product
    {
        private decimal precio;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price
        {
            get { return precio; }
            set {
                if (value >= 0)
                {
                    precio = value;
                }
                else {
                    throw new ArgumentException("El precio no puede ser negativo");
                }
            }
        }

        public ProductCategory Category { get; set; }                        
    }

}
