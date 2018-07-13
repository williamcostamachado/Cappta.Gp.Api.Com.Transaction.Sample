using Cappta.Gp.Api.Com.Transaction.Application;
using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Com.Transaction.Infra;
using Newtonsoft.Json;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public  class TransactionResponse
    {
        private IConnection connection;

        public TransactionResponse(IConnection connection)
        {
            this.connection = connection;
        }

        //ApiTransactionConnection connection = new ApiTransactionConnection();

        public  Response<Transaction> Search(TransactionFilter transactionFilter)
        {
            var transactionrRequest = new TransactionRequest();
            var response = transactionrRequest.Request(transactionFilter).Execute(connection.Open());
            return Deserialize(response);
        }

        public  Response<Transaction> Next(string url)
        {
            var transactionrRequest = new TransactionRequest();
            var response = transactionrRequest.Next(url).Execute(connection.Open());
            return Deserialize(response);
        }

        public  Response<Transaction> Previous(string url)
        {
            var transactionrRequest = new TransactionRequest();
            var response = transactionrRequest.Previous(url).Execute(connection.Open());
            return Deserialize(response);
        }

        private static Response<Transaction> Deserialize(RestSharp.IRestResponse response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent) { return null; }
            if (response.StatusCode == System.Net.HttpStatusCode.GatewayTimeout) { return null; }

            var transaction = JsonConvert.DeserializeObject<Response<Transaction>>(response.Content);

            return transaction;
        }
    }
}
