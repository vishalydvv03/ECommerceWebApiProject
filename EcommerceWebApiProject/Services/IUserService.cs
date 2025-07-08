using EcommerceWebApiProject.Models;

namespace EcommerceWebApiProject.Services
{
    public interface IUserService
    {

        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);

        Task UpdateAsync(User user);

        Task DeleteAsync(User user);

    }
}
