using night_life_sk.Data;

namespace night_life_sk.Services
{
    public class ScopedServiceProvider
    {
        private readonly IServiceProvider serviceProvider;

        public ScopedServiceProvider(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public T ExecuteFuncInScope<T>(Func<DataContext, T> operation)
        {
            using var scope = serviceProvider.CreateScope();
            var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            return operation(dataContext);
        }

        public void ExecuteActionInScope(Action<DataContext> operation)
        {
            using var scope = serviceProvider.CreateScope();
            var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            operation(dataContext);
        }
    }
}
