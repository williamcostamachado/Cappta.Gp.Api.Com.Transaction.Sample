using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Conciliacao.Aplication;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionProvider
    {
        TransactionResponse response = new TransactionResponse();

        public Response<Domain.Transaction> FindByFilter(TransactionFilter filter)
        {
            return response.Search(filter);
        }

        public Response<Domain.Transaction> FindNext(string url) { return response.Next(url); }
    
        public Response<Domain.Transaction> FindPrevious(string url) { return response.Previous(url); }
    }
}