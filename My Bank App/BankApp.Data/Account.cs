namespace BankApp.Data
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public AccountType AccountType { get; set; }
        public string FullName { get; set; }    
    }
  
}