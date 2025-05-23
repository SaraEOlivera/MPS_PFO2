using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Clases
{
    internal class ProductManager
    {

        private List<Product> productsList = new List<Product>();

        public ProductManager() { }

        public void addProdudct(Product newProduct) 
        {
            productsList.Add(newProduct);
        }

        public float calculateTotalPrice(Product product) 
        {
            if (product.Category == ProductCategory.Electronica)
            {
                return (float)(product.Price * 1.1);
            }
            else if (product.Category == ProductCategory.Alimentos)
            {
                return (float)(product.Price * 1.05);
            }
            else
            {
                throw new ArgumentException("La categoría ingresada no es válda");
            }
        }

        //public string findProductByName(Product product) 
        //{

        //}

    }
}
