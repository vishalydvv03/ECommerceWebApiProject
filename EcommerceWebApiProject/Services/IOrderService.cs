using EcommerceWebApiProject.Models;
using EcommerceWebApiProject.Models.DTO;

namespace EcommerceWebApiProject.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order?> GetOrderByIdAsync(int id);

        Task<bool> AddOrderAsync(OrderCreateDto dto);

        Task<bool> UpdateOrderAsync(int id, OrderCreateDto dto);

        Task<bool> DeleteOrderAsync(int id);
    }
}
