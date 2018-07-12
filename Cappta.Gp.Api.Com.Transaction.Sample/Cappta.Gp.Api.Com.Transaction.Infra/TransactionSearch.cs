using System;
using Cappta.Gp.Api.Com.Transaction.Domain;
using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionSearch
    {
        private string url;
        ApiResponse<PerformedTransaction> apiResponse = new ApiResponse<PerformedTransaction>();

        public TransactionSearch()
        {         
            this.url = "https://transactions.cappta.com.br/api/Transaction?";
        }

        public IRestClient Searh(TransactionFilter filter)
        {
            var urlBase = $@"{this.url}{filter.QueryString}";
            IRestClient restClient = new RestClient(urlBase);

            return restClient;
        }

        public  IRestClient Next (string url)
        {
            return CreateSearch(url);
        }

        public IRestClient Previous(string url)
        {
            return CreateSearch(url);
        }

        private IRestClient CreateSearch(string url)
        {
            var urlBase = url;
            IRestClient restClient = new RestClient(urlBase);
            return restClient;
        }
    }
}