using System;
using Cappta.Gp.Api.Com.Transaction.Application;
using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Com.Transaction.Infra;
using Newtonsoft.Json;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public  class TransactionResponse
    {
        public  ApiResponse<Transaction> Search(TransactionFilter transactionFilter)
        {
            var transactionrRequest = new TransactionRequest();
            var response = transactionrRequest.Request(transactionFilter).Execute(ApiTransactionConnection.Open());
            return CreateApiResponse(response);
        }

        public  ApiResponse<Transaction> FindNext(string url)
        {
            var transactionrRequest = new TransactionRequest();
            var response = transactionrRequest.Next(url).Execute(ApiTransactionConnection.Open());
            return CreateApiResponse(response);
        }

        public  ApiResponse<Transaction> FindPrevious(string url)
        {
            var transactionrRequest = new TransactionRequest();
            var response = transactionrRequest.Previous(url).Execute(ApiTransactionConnection.Open());
            return CreateApiResponse(response);
        }

        private static ApiResponse<Transaction> CreateApiResponse(RestSharp.IRestResponse response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent) { return null; }//HashSet<PerformedTransaction>(); }
            if (response.StatusCode == System.Net.HttpStatusCode.GatewayTimeout) { return null; }//new HashSet<PerformedTransaction>(); }

            var transaction = JsonConvert.DeserializeObject<ApiResponse<Transaction>>(response.Content);

            return transaction;
        }
    }
}
