using OOPlr8;

class Program
{
    static void Main()
    {
        Wallet wallet = new Wallet();
        //Account management

        Console.WriteLine("Add account");
        Account accountZero = new Account("qwerty");
        wallet.AddAccount(accountZero);
        Account accountOne = new Account("qwert", 100);
        wallet.AddAccount(accountOne);
        List<Account> accounts = wallet.Accounts;
        PrintAccounts(accounts);

        Console.WriteLine("Remove account");
        wallet.RemoveAccount(accountZero);
        PrintAccounts(accounts);
        List<Account> acs = wallet.Accounts;
        acs.Add(accountZero);
        PrintAccounts(accounts);

        //Console.WriteLine("Transfer money");
        //accountOne.TransferMoneyTo(accountZero, 50);
        //PrintAccounts(accounts);

        //Console.WriteLine("Remove account");
        //wallet.RemoveAccount(accountOne);
        //PrintAccounts(accounts);

        //Console.WriteLine("Change data");
        //Account mainAccount = wallet.Accounts[0];
        //mainAccount.ChangeBalance(200);
        //mainAccount.ChangeName("asd");
        //PrintAccounts(accounts);

        //Console.WriteLine("Show balance");
        //Console.WriteLine(mainAccount.Balance);

        ////Profits and expenses

        //Console.WriteLine("Add Profit");
        //mainAccount.AddProfit(new Profit(300));
        //PrintAccounts(accounts);
        //List<Profit> profits = mainAccount.GetProfitsFromTo(new Time(30, 5, 2024, 0, 0), new Time(30, 5, 2024, 23, 59));
        //PrintProfits(profits);

        //Console.WriteLine("Add expense");
        //mainAccount.AddExpense(new Expense(100));
        //PrintAccounts(accounts);
        //List<Expense> expensess = mainAccount.GetExpensesFromTo(new Time(30, 5, 2024, 0, 0), new Time(30, 5, 2024, 23, 59));
        //PrintExpenses(expensess);

        ////Categories
        //profits[0].AddCategory(new Category("Category1"));
        //profits[0].AddCategory(new Category("Category2"));
        //List<Category> profitCategories = profits[0].GetCategories();
        //PrintCategories(profitCategories);

        //Account account = new Account("q");

        //account.AddProfit(new Profit(10));
        //account.AddProfit(new Profit(40));
        //account.AddProfit(new Profit(50));
        //List<Profit> profits = account.GetProfitsFromTo(new Time(30, 5, 2024, 0, 0), new Time(30, 5, 2024, 23, 59));


    }
    public static void PrintAccounts(List<Account> accounts)
    {
        for (int i = 0; i < accounts.Count; i++)
        {
            Console.WriteLine(i + ". " + accounts[i].Name + " " + accounts[i].Balance);
        }
    }
    public static void PrintProfits(List<Profit> profits)
    {
        for (int i = 0; i < profits.Count; i++)
        {
            Profit k = profits[i];
            Console.WriteLine($"{i}. {k.Value} {k.Time.Hour}:{k.Time.Minute}");
        }
    }
    public static void PrintExpenses(List<Expense> expenses)
    {
        for (int i = 0; i < expenses.Count; i++)
        {
            Expense k = expenses[i];
            Console.WriteLine($"{i}. {k.Value} {k.Time.Hour}:{k.Time.Minute}");
        }
    }
    public static void PrintCategories(List<Category> categories)
    {
        for (int i = 0; i < categories.Count; i++)
        {
            Console.WriteLine(i + ". " + categories[i].Name + " ");
        }
    }
}