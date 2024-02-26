﻿using ProjectRepositoryPattern.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRepositoryPattern.BusinessLogic
{
    public class BusinessProduct
    {
        IProductRepository _repository;

        public BusinessProduct(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> Get()
        {
            return _repository.Get();
        }

        public Product Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Product model)
        {
            return _repository.Add(model);
        }

        public bool Update(Product model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
