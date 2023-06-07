namespace Bank_App.Core.Interface
{
    public interface IAccountService
    {
        void CheckBalance();
        void Deposit();
        void Transfer();
        void Withdraw();
        void DisplayAllTables();
    }
}