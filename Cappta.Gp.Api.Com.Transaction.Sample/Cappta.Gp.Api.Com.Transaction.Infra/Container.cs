using Autofac;

namespace Cappta.Gp.Api.Com.Transaction.Infra
{
    public class Container
    {
       public void RegisterDependenci()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Connection>().As<IConnection>();
        }
    }
}
