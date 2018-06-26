﻿using Newtonsoft.Json;
using System;

namespace Cappta.Gp.Api.Com.Transaction.Domain
{
    public class PerformadTransaction
    {
        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("checkoutCode")]
        public long? CheckoutCode { get; set; }

        [JsonProperty("uniqueSequentialNumber")]
        public string UniqueSequentialNumber { get; set; }

        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("amountIncents")]
        public long? AmountIncents { get; set; }

        [JsonProperty("installments")]
        public long? Installments { get; set; }

        [JsonProperty("administrativeCode")]
        public string AdministrativeCode { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty("transactionTypeCode")]
        public long? TransactionTypeCode { get; set; }

        [JsonProperty("acquirerName")]
        public string AcquirerName { get; set; }

        [JsonProperty("acquirerCode")]
        public long? AcquirerCode { get; set; }

        [JsonProperty("cardBrandName")]
        public string CardBrandName { get; set; }

        [JsonProperty("cerdBrandCode")]
        public long? CerdBrandCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public long? StatusCode { get; set; }

        [JsonProperty("responseCode")]
        public long? ResponseCode { get; set; }

        [JsonProperty("acquirerAuthorizationCode")]
        public long? AcquirerAuthorizationCode { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("dateUTC")]
        public DateTimeOffset? DateUtc { get; set; }

        [JsonProperty("acquirerUniqueSequentialNumber")]
        public long? AcquirerUniqueSequentialNumber { get; set; }
    }
}
