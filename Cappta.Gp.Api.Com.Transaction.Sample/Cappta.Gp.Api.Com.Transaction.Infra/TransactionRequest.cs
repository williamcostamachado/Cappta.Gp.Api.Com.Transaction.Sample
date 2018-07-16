using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Com.Transaction.Infra;
using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionRequest : ITransactionRequest
    {
        private string url;

        public TransactionRequest()
        {         
            this.url = "https://transactions.cappta.com.br/api/Transaction?";
        }

        public IRestClient Request(TransactionFilter transactionFilter)
        {
            var url = $@"{this.url}{transactionFilter.QueryString}";
            return Get(url);
        }

        public  IRestClient UrlRequest (string url) { return Get(url); }


        private IRestClient Get(string url)
        {
            var urlBase = url;
            IRestClient restClient = new RestClient(urlBase);
            return restClient;
        }

    }
}