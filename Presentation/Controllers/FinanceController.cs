using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion_architecture.Infrastructure.RecipesAPI;

namespace Onion_architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        private readonly IFinanceNews _financeNews;
        public FinanceController(IFinanceNews financeNews)
        {
            _financeNews = financeNews;
        }

        [HttpGet]
        public async Task<IActionResult> GetNews()
        {
            var news = await _financeNews.GetNews();
            return Ok(news);
        }
    }
}
