using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Com.Transaction.Infra;
using Newtonsoft.Json;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public  class TransactionProvider
    {
        private IConnection connection;
        private ITransactionRequest transactionRequest;

        public TransactionProvider(IConnection connection, ITransactionRequest transactionRequest)
        {
            this.connection = connection;
            this.transactionRequest = transactionRequest;
        }

        public Response<Transaction> FindByFilter(TransactionFilter filter)
        {
            if (filter.IsValid() == false) { return null; }

            return Search(filter);
        }

        public Response<Transaction> FindByUrl(string url) { return GetByUrl(url); }
       
        public  Response<Transaction> Search(TransactionFilter transactionFilter)
        {         
            var response = this.transactionRequest.Request(transactionFilter).Execute(connection.Open());
            return Deserialize(response);
        }

        public  Response<Transaction> GetByUrl(string url)
        {           
            var response = this.transactionRequest.UrlRequest(url).Execute(connection.Open());
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
