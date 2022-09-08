using Autofac;
using CADPLIS.Application.Contracts.WorkFlowDataAccess;

namespace CADPLIS.Server.ServiceLocation
{
    public class DataServiceProvider : IDataServiceProvider
    {
        private readonly IContainer _container;

        public DataServiceProvider(IContainer container)
        {
            _container = container;
        }

        public T Get<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
