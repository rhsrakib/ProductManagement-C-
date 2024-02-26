using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRepositoryPattern.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        List<Product> listCustomer = new List<Product>()
        {
            new Product(1, "Mboard", 9999),
            new Product(2, "CPU", 17500),
            new Product(3, "Monitor", 11200),
            new Product(4, "RAM", 3500),
            new Product(5, "SSD", 5200),
            new Product(6, "PSupply", 100),
            new Product(7, "Keybord", 500),
            new Product(8, "Mouse", 350),
            new Product(9, "Casing", 300),
            new Product(10, "UPS", 4000)
        };
        public List<Product> Get()
        {
            return listCustomer.OrderBy(x => x.ProductName).ToList();
        }
        public Product Get(int id)
        {
            Product oCustomer = listCustomer.Where(x => x.ProductId == id).FirstOrDefault();
            return oCustomer;
        }
        public bool Add(Product model)
        {
            listCustomer.Add(model);
            return true;
        }
        public bool Update(Product model)
        {
            bool isExecuted = false;
            Product oCustomer = listCustomer.Where(x => x.ProductId == model.ProductId).FirstOrDefault();
            if (oCustomer != null)
            {
                listCustomer.Remove(oCustomer);
                listCustomer.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
        public bool Delete(int id)
        {
            bool isExecuted = false;
            Product oCustomer = listCustomer.Where(x => x.ProductId == id).FirstOrDefault();
            if (oCustomer != null)
            {
                listCustomer.Remove(oCustomer);
                isExecuted = true;
            }
            return isExecuted;
        }

    }
}
