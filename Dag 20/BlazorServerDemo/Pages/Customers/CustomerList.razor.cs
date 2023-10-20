using BlazorServerDemo.Data;
using BlazorServerDemo.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerDemo.Pages.Customers
{
    partial class CustomerList
    {
        [Inject]
        protected ICustomerService CustomerService { get; set; }

        protected List<Customer> Customers { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Customers = await CustomerService.GetCustomers();
        }
    }
}
