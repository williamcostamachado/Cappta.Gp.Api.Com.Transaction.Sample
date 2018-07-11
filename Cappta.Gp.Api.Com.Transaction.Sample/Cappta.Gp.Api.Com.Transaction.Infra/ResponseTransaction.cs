using Cappta.Gp.Api.Com.Transaction.Application;
using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Com.Transaction.Infra;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public static class ResponseTransaction
    {
        public static ApiResponse<PerformedTransaction> FindByFilter(TransactionFilter filter)
        {
            var transactionSearch = new TransactionSearch();
            var response = transactionSearch.Searh(filter).Execute(ApiTransactionConnection.Open());
            return CreateApiResponse(response);
        }

        public static ApiResponse<PerformedTransaction> FindNext(string url)
        {
            var transactionSearch = new TransactionSearch();
            var response = transactionSearch.Next(url).Execute(ApiTransactionConnection.Open());
            return CreateApiResponse(response);
        }

        private static ApiResponse<PerformedTransaction> CreateApiResponse(RestSharp.IRestResponse response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent) { return null; }//HashSet<PerformedTransaction>(); }
            if (response.StatusCode == System.Net.HttpStatusCode.GatewayTimeout) { return null; }//new HashSet<PerformedTransaction>(); }

            var transaction = JsonConvert.DeserializeObject<ApiResponse<PerformedTransaction>>(response.Content);

            return transaction;
        }
    }
}
