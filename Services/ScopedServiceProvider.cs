using night_life_sk.Data;

namespace night_life_sk.Services
{
    internal class ScopedServiceProvider
    {
        private readonly IServiceProvider serviceProvider;

        public ScopedServiceProvider(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        internal async Task<T> ExecuteFuncInScopeAsync<T>(Func<DataContext, Task<T>> operation)
        {
            using var scope = serviceProvider.CreateScope();
            var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            return await operation(dataContext);
        }

        internal async Task ExecuteActionInScopeAsync(Func<DataContext, Task> operation)
        {
            using var scope = serviceProvider.CreateScope();
            var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            await operation(dataContext);
        }
    }
}
