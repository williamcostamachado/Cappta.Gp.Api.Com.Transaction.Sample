using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Conciliacao.Aplication;
using System;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Com.Transaction.Application
{
    public class TransactionProvider
    {
        ResponseTransaction response = new ResponseTransaction();

        public ApiResponse<PerformedTransaction> GetSales(TransactionFilter filter)
        {
            return response.FindByFilter(filter);
        }

        public ApiResponse<PerformedTransaction> GetNext(string url)
        {
            return response.FindNext(url);
        }

        public ApiResponse<PerformedTransaction> GetPrevious(string url)
        {
            return response.FindPrevious(url);
        }
    }
}