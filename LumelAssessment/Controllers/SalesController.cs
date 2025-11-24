using LumelAssessment.Services.Sales;
using Microsoft.AspNetCore.Mvc;

namespace LumelAssessment.Controllers
{
    [ApiController]
    public class SalesController : Controller
    {
        public readonly ISalesServices _salesServices;
        public SalesController(ISalesServices salesServices)
        {
            _salesServices = salesServices;
        }

        [HttpGet]
        [Route("api/sales/summary")]
        public async Task<IActionResult> GetSummary()
            => await _salesServices.GetSalesSummary();

        [HttpPost]
        [Route("api/sales/upload")]
        public async Task<IActionResult> UploadSalesData()
        {
            // Implementation for uploading sales data would go here
            return Ok(new { Message = "Sales data uploaded successfully." });
        }

    }
}
