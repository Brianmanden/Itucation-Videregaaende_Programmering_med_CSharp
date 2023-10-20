using BlazorServerDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerDemo.Services;

public class CustomerService : ICustomerService
{
    private readonly KundeDbContext _context;
    public CustomerService(KundeDbContext dbContext)
    {
        _context = dbContext;
    }
    public async Task<List<Customer>> GetCustomers()
    {
        return await _context.Customers.ToListAsync();

    }
}