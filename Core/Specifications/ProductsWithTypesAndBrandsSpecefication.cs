using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecefication : BaseSpecefication<Product>
    {
        public ProductsWithTypesAndBrandsSpecefication()
        {
            AddInclude(p=>p.ProductBrand);
            AddInclude(p=>p.ProductType);
        }

        public ProductsWithTypesAndBrandsSpecefication(int id) : base(p=>p.Id == id)
        {
            AddInclude(p=>p.ProductBrand);
            AddInclude(p=>p.ProductType);
        }
    }
}