namespace Dreamer.Blog.API.Extensions;

internal static class ServiceExtension
{
    public static void AddApplicationServices(this IServiceCollection services) => services.AddScoped<IExampleService, ExampleService>();// Add custom application services here
}

internal class ExampleService : IExampleService
{
}

internal interface IExampleService
{
}
