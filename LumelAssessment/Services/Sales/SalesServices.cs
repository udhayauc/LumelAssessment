using Microsoft.AspNetCore.Mvc;

namespace LumelAssessment.Services.Sales
{
    public class SalesServices : ControllerBase, ISalesServices
    {
        public SalesServices() { }

        public async Task<IActionResult> GetSalesSummary()
        {
            // Dummy implementation for demonstration purposes
            var salesSummary = new
            {
                TotalSales = 100000,
                TotalOrders = 2500,
                TopSellingProduct = "Product A"
            };
            return Ok(salesSummary);
        }
    }
}
