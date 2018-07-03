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
        public static IEnumerable<PerformedTransaction> FindByFilter(TransactionFilter filter)
        {
            var search = new TransactionSearch();
            var response = search.Searh(filter).Execute(ApiTransactionConnection.Open());

            if (response.StatusCode == System.Net.HttpStatusCode.NoContent) { return new HashSet<PerformedTransaction>(); }

            var transaction = JsonConvert.DeserializeObject<ApiResponse<PerformedTransaction>>(response.Content);

            return transaction.Results;
        }
    }
}
