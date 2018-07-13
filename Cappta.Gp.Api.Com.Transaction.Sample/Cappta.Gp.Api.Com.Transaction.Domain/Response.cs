using Newtonsoft.Json;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Com.Transaction.Domain
{
    public class Response<T>
    {
        [JsonProperty("results")]
        public IEnumerable<T> Results { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}
