using EcommerceWebApiProject.Models;
using EcommerceWebApiProject.Models.DTO;

namespace EcommerceWebApiProject.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task<bool> AddProductAsync(ProductCreateDto dto);
        Task<bool> UpdateProductAsync(ProductCreateDto dto, Product product);
        Task DeleteProductAsync(Product product);
    }
}
