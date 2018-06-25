using Newtonsoft.Json;
using System;

namespace Cappta.Gp.Api.Com.Transaction.Domain
{
    public class Transaction
    {
       
        public partial class Result
        {
            [JsonProperty("cnpj", NullValueHandling = NullValueHandling.Ignore)]
            public string Cnpj { get; set; }

            [JsonProperty("checkoutCode", NullValueHandling = NullValueHandling.Ignore)]
            public long? CheckoutCode { get; set; }

            [JsonProperty("uniqueSequentialNumber", NullValueHandling = NullValueHandling.Ignore)]
            public string UniqueSequentialNumber { get; set; }

            [JsonProperty("cardNumber", NullValueHandling = NullValueHandling.Ignore)]
            public string CardNumber { get; set; }

            [JsonProperty("amountIncents", NullValueHandling = NullValueHandling.Ignore)]
            public long? AmountIncents { get; set; }

            [JsonProperty("installments", NullValueHandling = NullValueHandling.Ignore)]
            public long? Installments { get; set; }

            [JsonProperty("administrativeCode", NullValueHandling = NullValueHandling.Ignore)]
            public string AdministrativeCode { get; set; }

            [JsonProperty("transactionType", NullValueHandling = NullValueHandling.Ignore)]
            public string TransactionType { get; set; }

            [JsonProperty("transactionTypeCode", NullValueHandling = NullValueHandling.Ignore)]
            public long? TransactionTypeCode { get; set; }

            [JsonProperty("acquirerName", NullValueHandling = NullValueHandling.Ignore)]
            public string AcquirerName { get; set; }

            [JsonProperty("acquirerCode", NullValueHandling = NullValueHandling.Ignore)]
            public long? AcquirerCode { get; set; }

            [JsonProperty("cardBrandName", NullValueHandling = NullValueHandling.Ignore)]
            public string CardBrandName { get; set; }

            [JsonProperty("cerdBrandCode", NullValueHandling = NullValueHandling.Ignore)]
            public long? CerdBrandCode { get; set; }

            [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public string Status { get; set; }

            [JsonProperty("statusCode", NullValueHandling = NullValueHandling.Ignore)]
            public long? StatusCode { get; set; }

            [JsonProperty("responseCode", NullValueHandling = NullValueHandling.Ignore)]
            public long? ResponseCode { get; set; }

            [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
            public DateTimeOffset? Date { get; set; }

            [JsonProperty("dateUTC", NullValueHandling = NullValueHandling.Ignore)]
            public DateTimeOffset? DateUtc { get; set; }

        }

    }
}
