using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Conciliacao.Aplication;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionProvider
    {
        public IEnumerable<PerformedTransaction> GetSales(TransactionFilter filter)
        {
            return ResponseTransaction.FindByFilter(filter);
        }
    }
}