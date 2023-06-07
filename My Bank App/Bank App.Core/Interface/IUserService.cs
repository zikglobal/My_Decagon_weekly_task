using BankApp.Data;
using BankApp.Data.Dtos;

namespace Bank_App.Core.Interface
{
    public interface IUserService
    {
        User? user { get; set; }

        void LogIn(string email, string password);
        void LogOut();
        void Register(RegisterDto register);
    }
}