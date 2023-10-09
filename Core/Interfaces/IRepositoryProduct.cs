using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IRepositoryProduct
    {
        Task<Product> GetProductAsync(int id);
        Task<List<Product>> GetProductsAsync();
        Task<List<ProductBrand>> GetProductBrandsAsync();
        Task<List<ProductType>> GetProductTypesAsync();
    }
}