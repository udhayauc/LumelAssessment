using Microsoft.AspNetCore.Mvc;

namespace LumelAssessment.Services.Customer
{
    public interface ICustomerServices
    {
        Task<IActionResult> GetCustomerDetailsAsync();
        Task<IActionResult> RegisterCustomerAsync();
        Task<IActionResult> UploadCustomerDataAsync();
    }
}
