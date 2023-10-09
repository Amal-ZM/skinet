using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
             if(!context.ProductBrands.Any()){
                var brandsData = File.ReadAllText("../Infrastructure/SeedData/brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                context.ProductBrands.AddRange(brands);
            }
            if(!context.ProductTypes.Any()){
                var tybesdata = File.ReadAllText("../infrastructure/seeddata/types.json");
                var tybes = JsonSerializer.Deserialize<List<ProductType>>(tybesdata);
                context.ProductTypes.AddRange(tybes);
            }
             if(!context.Products.Any()){
                var productsdata = File.ReadAllText("../infrastructure/seeddata/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsdata);
                context.Products.AddRange(products);
            }
            if(context.ChangeTracker.HasChanges()){
                await context.SaveChangesAsync();
            }
        }
    }
}