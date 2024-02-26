using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRepositoryPattern.DataAccess
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public double ProductCost;
        public Product()
        {
        }
        public Product(int pId, string pName, double pCost)
        {
            ProductId = pId;
            ProductName = pName;
            ProductCost = pCost;
        }

    }
}
