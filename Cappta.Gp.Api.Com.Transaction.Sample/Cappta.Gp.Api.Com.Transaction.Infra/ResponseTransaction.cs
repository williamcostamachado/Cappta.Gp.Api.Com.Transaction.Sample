using Cappta.Gp.Api.Com.Transaction.Application;
using Cappta.Gp.Api.Com.Transaction.Domain;
using Cappta.Gp.Api.Com.Transaction.Infra;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public static class ResponseTransaction
    {
        public static IEnumerable<PerformadTransaction> FindByFilter(TransactionFilter filter)
        {
            var search = new TransactionSearch();
            var response = search.Searh(filter).Execute(ApiTransactionConnection.Open());
            var transaction = JsonConvert.DeserializeObject<PerformadTransaction[]>(response.Content);

            return transaction;
        }

        private TransactionFilter CreateFilter()
        {
            return new TransactionFilter()
            {
                Cnpj = "08476665000188",
                Nsu = "010255",
                FinalDate = Convert.ToDateTime("2018/02/01"),
                InitialDate = Convert.ToDateTime("2018/02/01")
            };
        }
    }
}
