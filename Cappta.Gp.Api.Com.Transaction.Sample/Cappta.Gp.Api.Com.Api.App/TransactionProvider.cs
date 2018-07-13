using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Conciliacao.Aplication;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionProvider
    {
        TransactionResponse response = new TransactionResponse();

        public ApiResponse<Domain.Transaction> FindByFilter(TransactionFilter filter)
        {
            return response.Search(filter);
        }

        public ApiResponse<Domain.Transaction> FindNext(string url)
        {
            return response.FindNext(url);
        }

        public ApiResponse<Domain.Transaction> FindPrevious(string url)
        {
            return response.FindPrevious(url);
        }
    }
}