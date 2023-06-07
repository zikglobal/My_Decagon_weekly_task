using Bank_App.Core.Interface;
using Bank_App.Core.implementation;
using Microsoft.Extensions.DependencyInjection;
using Bank_App.Core.Implementation;
namespace Bank_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceCollection();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<ICreateAccountService, CreateAccountService>();
            service.AddScoped<IAccountService, AccountService>();
            service.AddScoped<IMenu, Menu>();
            service.AddSingleton<UserInterface>();

            var serviceProvider = service.BuildServiceProvider();
            var userInterface = serviceProvider.GetRequiredService<UserInterface>();

            userInterface.Run();


        }
    }
}