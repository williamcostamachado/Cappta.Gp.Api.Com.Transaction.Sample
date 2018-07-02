using Cappta.Gp.Api.Com.Transaction.Domain;
using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionSearch
    {
        private string url;
        //private IRestClient restClient;

        public TransactionSearch()
        {
            this.url = "https://transactions.cappta.com.br/api/Transaction?";
        }

        public RestClient Searh(TransactionFilter filter)
        {
            var urlBase = $@"{this.url}{filter.QueryString}";
            var restClient = new RestClient(urlBase);

            return restClient;
        }

    }
}