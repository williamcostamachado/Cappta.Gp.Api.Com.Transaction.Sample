using Cappta.Gp.Api.Com.Transaction.Domain;
using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Infra
{
    public interface ITransactionRequest
    {
         IRestClient Request(TransactionFilter transactionFilter);

         IRestClient UrlRequest(string url);

    }
}
