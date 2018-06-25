﻿using System;

namespace Cappta.Gp.Api.Com.Transaction.Domain
{
    class TransactionFilter
    {
        public TransactionFilter(InstallmentType type)
        {
            if (type == InstallmentType.Undefined) { throw new ArgumentException(nameof(type)); }
            this.InstallmentType = type;
        }

        public string Cnpj { get; set; }
        public DateTime FinalDate { get; set; }
        public DateTime InitialDate { get; set; }
        public string Nsu { get; set; }
        public InstallmentType InstallmentType { get; private set; }

        public bool IsValid()
        {
            var initialDateIsValid = this.IsValidDateTime(this.InitialDate);
            var finalDateIsValid = this.IsValidDateTime(this.FinalDate);

            return this.HasValidCnpj() && initialDateIsValid && finalDateIsValid;
        }

        private bool HasValidCnpj()
        {
            return String.IsNullOrWhiteSpace(this.Cnpj) == false || this.Cnpj.Length == 14 || String.IsNullOrEmpty(this.Cnpj);
        }

        private bool HasValidNsu()
        {
            return String.IsNullOrWhiteSpace(this.Nsu) == false || this.Nsu.Length == 6;
        }

        private bool IsValidDateTime(DateTime fieldDate)
        {
            return fieldDate != default(DateTime);
        }

        public string QueryString
        {
            get
            {
                var urlBuilder = new System.Text.StringBuilder();

                urlBuilder.Append($"{InstallmentType.ToString()}/");
                urlBuilder.Append(this.Cnpj);
                urlBuilder.Append($"?initialDate={this.InitialDate}");
                urlBuilder.Append($"&finalDate={this.FinalDate}");

                if (this.HasValidNsu()) { urlBuilder.Append($"&nsu={this.Nsu}"); }

                return urlBuilder.ToString();
            }
        }
    }
}