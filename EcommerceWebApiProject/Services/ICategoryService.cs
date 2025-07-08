using EcommerceWebApiProject.Models;
using EcommerceWebApiProject.Models.DTO;

namespace EcommerceWebApiProject.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(Category category);

        Task UpdateCategoryAsync();

        Task DeleteCategoryAsync(Category category);
    }
}
