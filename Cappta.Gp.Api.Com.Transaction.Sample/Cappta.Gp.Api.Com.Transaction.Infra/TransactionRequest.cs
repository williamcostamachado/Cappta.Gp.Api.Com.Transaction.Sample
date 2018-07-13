using System;
using Cappta.Gp.Api.Com.Transaction.Domain;
using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionRequest
    {
        private string url;
        ApiResponse<Domain.Transaction> apiResponse = new ApiResponse<Domain.Transaction>();

        public TransactionRequest()
        {         
            this.url = "https://transactions.cappta.com.br/api/Transaction?";
        }

        public IRestClient Request(TransactionFilter filter)
        {
            var urlBase = $@"{this.url}{filter.QueryString}";
            IRestClient restClient = new RestClient(urlBase);

            return restClient;
        }

        public  IRestClient Next (string url)
        {
            return Get(url);
        }

        public IRestClient Previous(string url)
        {
            return Get(url);
        }

        private IRestClient Get(string url)
        {
            var urlBase = url;
            IRestClient restClient = new RestClient(urlBase);
            return restClient;
        }
    }
}