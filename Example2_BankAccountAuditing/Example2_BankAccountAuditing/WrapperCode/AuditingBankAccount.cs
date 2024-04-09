using Example2_BankAccountAuditing.Interface;
using Example2_BankAccountAuditing.OriginalCode;
using System.Text;

namespace Example2_BankAccountAuditing.WrapperCode
{
    public class AuditingBankAccount : IBankAccount
    {
        public string AccountId => _bankAccount.AccountId;
        public string AccountName => _bankAccount.AccountName;
        public decimal CurrentFunds => _bankAccount.CurrentFunds;

        public ICollection<string> Audit { get; private set; }

        private readonly IBankAccount _bankAccount;

        public AuditingBankAccount(BankAccount bankAccount)
        {
            _bankAccount = bankAccount;
            Audit = new List<string>();
        }

        public void AddFunds(decimal funds)
        {
            var audit = new StringBuilder();
            audit.AppendLine($"Current funds [{CurrentFunds}]");
            audit.AppendLine($"Funds to add [{funds}]");
            _bankAccount.AddFunds(funds);
            audit.Append($"New current funds [{CurrentFunds}]");
            Audit.Add(audit.ToString());
        }

        public void RemoveFunds(decimal funds)
        {
            var audit = new StringBuilder();
            audit.AppendLine($"Current funds [{CurrentFunds}]");
            audit.AppendLine($"Funds to remove [{funds}] ");
            _bankAccount.RemoveFunds(funds);
            audit.Append($"New current funds [{CurrentFunds}]");
            Audit.Add(audit.ToString());
        }

        public void UpdateDetails(string name)
        {
            var audit = new StringBuilder();
            audit.AppendLine($"Current account name [{AccountName}]");
            _bankAccount.UpdateDetails(name);
            audit.AppendLine($"New account name [{AccountName}]");
            Audit.Add(audit.ToString());
        }
    }
}
