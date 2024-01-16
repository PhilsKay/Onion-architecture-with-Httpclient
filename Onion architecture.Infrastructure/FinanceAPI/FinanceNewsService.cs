using Onion_architecture.Infrastructure.FinanceAPI.Entities;
using Onion_architecture.Infrastructure.RecipesAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Onion_architecture.Infrastructure.FinanceAPI
{
    public class FinanceNewsService : IFinanceNews
    { 
        private readonly IHttpClientFactory _httpClientFactory;
        public FinanceNewsService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<FinanceNews> GetNews()
        {
            var finance = _httpClientFactory.CreateClient("Finance-news");
            try
            {
                var news = await finance.GetAsync("financelayer/news?date=today&keyword=bitcoin");

                if (news.IsSuccessStatusCode)
                {
                    var data = await news.Content.ReadAsStringAsync();
                    FinanceNews financeNews = JsonSerializer.Deserialize<FinanceNews>(data);
                    return financeNews;
                }
                else
                {
                    return new FinanceNews();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
