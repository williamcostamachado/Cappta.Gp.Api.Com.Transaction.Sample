﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Com.Transaction.Domain
{
    public class ApiResponse<T>
    {
        public ApiResponse()
        {
            this.Results = new HashSet<T>();
        }

        [JsonProperty("results")]
        public IEnumerable<T> Results { get; set; }
    }
}