using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Infra
{
    public static class ApiTransactionConnection
    {
        public static RestRequest Open()
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("token", "e9875bb743aa4afc915c7ab8a96b9c9b");
            return request;
        }
    }
}
