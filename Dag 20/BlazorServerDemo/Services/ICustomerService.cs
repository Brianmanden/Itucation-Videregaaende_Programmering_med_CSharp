using BlazorServerDemo.Data;

namespace BlazorServerDemo.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
    }
}
