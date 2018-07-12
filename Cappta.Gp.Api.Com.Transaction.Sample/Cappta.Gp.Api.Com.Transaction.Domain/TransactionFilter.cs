using System;

namespace Cappta.Gp.Api.Com.Transaction.Domain
{
    public class TransactionFilter
    {
        public string Cnpj { get; set; }
        public string FinalDate { get; set; }
        public string InitialDate { get; set; }
        public string UniqueSequentialNumber { get; set; }
        public int Pdv { get; set; }
        public string AdministrativeCode { get; set; }
        
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
            return String.IsNullOrWhiteSpace(this.UniqueSequentialNumber) == false || this.UniqueSequentialNumber.Length == 6;
        }

        private bool IsValidDateTime(string fieldDate)
        {
            return string.IsNullOrWhiteSpace(fieldDate) == false;
        }

        private bool HasValidAdministrativeCode()
        {
            return String.IsNullOrWhiteSpace(this.AdministrativeCode) == false ||  String.IsNullOrEmpty(this.AdministrativeCode) == false || AdministrativeCode.Length == 11;
        }

        private bool HasValidPdv()
        {
            return Pdv.Equals(0) == false;
        }

        public string QueryString
        {
            get
            {
                var urlBuilder = new System.Text.StringBuilder();
                urlBuilder.Append($"cnpj={this.Cnpj}");
                urlBuilder.Append($"&initialDate={this.InitialDate}");
                urlBuilder.Append($"&finalDate={this.FinalDate}");
                if (this.HasValidPdv()) { urlBuilder.Append($"&checkoutCode={this.Pdv}"); }
                if (this.HasValidNsu()) { urlBuilder.Append($"&uniqueSequentialNumber={this.UniqueSequentialNumber}"); }
                if (this.HasValidAdministrativeCode()) { urlBuilder.Append($"&administrativeCode={this.AdministrativeCode}"); }
                urlBuilder.Append($"&limit=15");

                return urlBuilder.ToString();
            }
        }
    }
}
