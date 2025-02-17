using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace TelegramBotDependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAllImplementationsOf<TInterface>(this IServiceCollection services)
        where TInterface : class
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(TInterface).IsAssignableFrom(t));

        foreach (var type in types)
        {
            services.AddScoped(typeof(TInterface), type);
        }

        return services;
    }
}