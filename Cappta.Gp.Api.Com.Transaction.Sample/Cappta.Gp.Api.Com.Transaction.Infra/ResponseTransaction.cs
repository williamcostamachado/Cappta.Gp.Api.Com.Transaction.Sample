using System;
using Cappta.Gp.Api.Com.Transaction.Application;
using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Com.Transaction.Infra;
using Newtonsoft.Json;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public  class ResponseTransaction
    {
        public  ApiResponse<PerformedTransaction> FindByFilter(TransactionFilter filter)
        {
            var transactionSearch = new TransactionSearch();
            var response = transactionSearch.Searh(filter).Execute(ApiTransactionConnection.Open());
            return CreateApiResponse(response);
        }

        public  ApiResponse<PerformedTransaction> FindNext(string url)
        {
            var transactionSearch = new TransactionSearch();
            var response = transactionSearch.Next(url).Execute(ApiTransactionConnection.Open());
            return CreateApiResponse(response);
        }

        public  ApiResponse<PerformedTransaction> FindPrevious(string url)
        {
            var transactionSearch = new TransactionSearch();
            var response = transactionSearch.Previous(url).Execute(ApiTransactionConnection.Open());
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
