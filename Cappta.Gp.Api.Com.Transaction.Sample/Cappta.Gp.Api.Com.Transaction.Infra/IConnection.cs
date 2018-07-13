using RestSharp;

namespace Cappta.Gp.Api.Com.Transaction.Infra
{
   public  interface IConnection
    {
        IRestRequest Open();
    }
}
