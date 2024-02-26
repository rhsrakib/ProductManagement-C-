using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRepositoryPattern.DataAccess
{
    public interface IProductRepository
    {
        List<Product> Get();
        Product Get(int id);
        bool Add(Product model);
        bool Update(Product model);
        bool Delete(int id);

    }
}
