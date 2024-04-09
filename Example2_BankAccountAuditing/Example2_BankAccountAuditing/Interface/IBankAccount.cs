namespace Example2_BankAccountAuditing.Interface
{
    public interface IBankAccount
    {
        string AccountId { get; }
        string AccountName { get; }
        decimal CurrentFunds { get; }
        void AddFunds(decimal funds);
        void RemoveFunds(decimal funds);
        void UpdateDetails(string name);
    }
}