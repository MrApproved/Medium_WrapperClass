using Example2_BankAccountAuditing.Interface;
using Example2_BankAccountAuditing.OriginalCode;
using Example2_BankAccountAuditing.WrapperCode;

internal class Program
{
    static void Main(string[] args)
    {
        // Original code
        Console.WriteLine("--- Not wrapped code ---");
        var accountId = Guid.NewGuid().ToString();
        var accountName = "Account Name";
        var funds = 0m;
        var bankAccount = new BankAccount(accountId, accountName, funds);

        PrintBankDetails(bankAccount);
        bankAccount.AddFunds(1.23m);
        bankAccount.RemoveFunds(1m);
        bankAccount.UpdateDetails("Name Account");
        PrintBankDetails(bankAccount);

        // Wrapper code
        Console.WriteLine("------------");
        Console.WriteLine("------------");
        Console.WriteLine("------------");

        Console.WriteLine("--- Wrapper code ---");
        bankAccount = new BankAccount(accountId, accountName, funds);
        var auditingBankAccount = new AuditingBankAccount(bankAccount);

        PrintBankDetails(auditingBankAccount);
        auditingBankAccount.AddFunds(1.23m);
        auditingBankAccount.RemoveFunds(1m);
        auditingBankAccount.UpdateDetails("Name Account");
        PrintBankDetails(auditingBankAccount);
        foreach (var audit in auditingBankAccount.Audit)
            Console.WriteLine(audit);

        void PrintBankDetails(IBankAccount ba)
        {
            Console.WriteLine($"--- Bank details ---");
            Console.WriteLine($"{ba.AccountId}");
            Console.WriteLine($"{ba.AccountName}: {ba.CurrentFunds}");
            Console.WriteLine($"--- End of details ---");
            Console.WriteLine();
        }
    }
}