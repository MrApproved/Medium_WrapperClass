using Example2_BankAccountAuditing.Interface;

namespace Example2_BankAccountAuditing.OriginalCode
{
    public class BankAccount : IBankAccount
    {
        public string AccountId { get; private set; }
        public string AccountName { get; private set; }
        public decimal CurrentFunds { get; private set; }

        public BankAccount(string accountId, string accountName, decimal currentFunds)
        {
            AccountId = accountId;
            AccountName = accountName;
            CurrentFunds = currentFunds;
        }

        public void AddFunds(decimal funds)
            => CurrentFunds += funds < 0 ? 0 : funds;

        public void RemoveFunds(decimal funds)
            => CurrentFunds -= funds < 0 ? 0 : funds;

        public void UpdateDetails(string name)
            => AccountName = string.IsNullOrWhiteSpace(name) ? AccountName : name;
    }
}