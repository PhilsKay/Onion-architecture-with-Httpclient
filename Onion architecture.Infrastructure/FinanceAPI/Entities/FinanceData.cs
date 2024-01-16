using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_architecture.Infrastructure.FinanceAPI.Entities
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Datum
    {
        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("tickers")]
        public List<string> tickers { get; set; }

        [JsonProperty("tags")]
        public List<string> tags { get; set; }

        [JsonProperty("published_at")]
        public DateTime published_at { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("limit")]
        public int limit { get; set; }

        [JsonProperty("offset")]
        public int offset { get; set; }

        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("total")]
        public int total { get; set; }
    }

    public class FinanceNews
    {
        [JsonProperty("pagination")]
        public Pagination pagination { get; set; }

        [JsonProperty("data")]
        public List<Datum> data { get; set; }
    }


}
