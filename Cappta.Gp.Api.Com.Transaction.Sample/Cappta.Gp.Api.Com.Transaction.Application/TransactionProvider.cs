using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Conciliacao.Aplication;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public static class TransactionProvider
    {
        public static IEnumerable<PerformadTransaction> GetSales(TransactionFilter filter)
        {
            return ResponseTransaction.FindByFilter(filter);
        }
    }
}
