using Cappta.Gp.Api.Com.Transaction.Domain;
using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionRequest
    {
        private string url;

        public TransactionRequest()
        {         
            this.url = "https://transactions.cappta.com.br/api/Transaction?";
        }

        public IRestClient Request(TransactionFilter transactionFilter)// GrtByFilter
        {
            var url = $@"{this.url}{transactionFilter.QueryString}";
            return Get(url);
        }

        public  IRestClient Next (string url) { return Get(url); }

        public IRestClient Previous(string url) { return Get(url); }

        private IRestClient Get(string url)// GrtByUrl
        {
            var urlBase = url;
            IRestClient restClient = new RestClient(urlBase);
            return restClient;
        }
    }// criaria uma pasta chamada api externa e renomeava esta classe para repositorio de transações
}