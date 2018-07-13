using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Infra
{
    public  class Connection: IConnection
    {
        public  IRestRequest Open()
        {
            IRestRequest request = new RestRequest(Method.GET);
            request.AddHeader("token", "e9875bb743aa4afc915c7ab8a96b9c9b");
            return request;
        }
    }
}
