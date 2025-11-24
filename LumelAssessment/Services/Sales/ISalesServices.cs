using Microsoft.AspNetCore.Mvc;

namespace LumelAssessment.Services.Sales
{
    public interface ISalesServices
    {
        Task<IActionResult> GetSalesSummary();
    }
}
