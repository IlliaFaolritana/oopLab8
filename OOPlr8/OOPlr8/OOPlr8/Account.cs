using System.Collections;

namespace OOPlr8
{
    class Account //: IEnumerable<Profit>, IEnumerable<Expense>
    {
        private string name;
        private int balance;
        private readonly List<Profit> profits;
        private readonly List<Expense> expenses;

        public Account(string name)
        {
            this.name = name;
            balance = 0;
            profits = new List<Profit>();
            expenses = new List<Expense>();
        }
        public Account(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
            profits = new List<Profit>();
            expenses = new List<Expense>();
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void ChangeName(string newName)
        {
            name = newName;
        }
        public void ChangeBalance(int newBalance)
        {
            balance = newBalance;
        }
        public void AddProfit(Profit profit)
        {
            profits.Add(profit);
            Balance += profit.Value;
        }
        public void RemoveProfit(Profit profit)
        {
            if(profits.Remove(profit))
                Balance -= profit.Value;
        }
        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
            Balance -= expense.Value;
        }
        public void RemoveExpense(Expense expense)
        {
            if (expenses.Remove(expense))
                Balance += expense.Value;
        }
        public void TransferMoneyTo(Account account, int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException($"{amount} must be positive");
            AddExpense(new Expense(amount));
            account.AddProfit(new Profit(amount));
        }
        public List<Profit> GetProfitsFromTo(Time from, Time to)
        {
            List<Profit> profitsFromTo = new List<Profit>();
            foreach (Profit profit in profits)
            {
                if(profit.Time.IsWithinRange(from, to))
                    profitsFromTo.Add(profit);
            }
            return profitsFromTo;
        }
        public List<Expense> GetExpensesFromTo(Time from, Time to)
        {
            List<Expense> expensesFromTo = new List<Expense>();
            foreach (Expense expense in expenses)
            {
                if (expense.Time.IsWithinRange(from, to))
                    expensesFromTo.Add(expense);
            }
            return expensesFromTo;
        }
        public List<Profit> GetProfitsByCategory(Category category)
        {
            List<Profit> profitsByCategory = new List<Profit>();
            foreach(Profit profit in profits)
            {
                if(profit.HasCategory(category))
                    profitsByCategory.Add(profit);
            }
            return profitsByCategory;
        }
        public List<Expense> GetExpensesByCategory(Category category)
        {
            List<Expense> expensesByCategory = new List<Expense>();
            foreach (Expense expense in expenses)
            {
                if (expense.HasCategory(category))
                    expensesByCategory.Add(expense);
            }
            return expensesByCategory;
        }
        public int GetProfitsStaticticsByDate(Time from, Time to)
        {
            List <Profit> profitsByDate = GetProfitsFromTo(from, to);
            int sum = 0;
            int counter = 0;
            foreach (Profit profit in profitsByDate)
            {
                sum += profit.Value;
                counter++;
            }
            if (counter == 0)
                return 0;
            return sum / counter;
        }
        public int GetExpensesStaticticsByDate(Time from, Time to)
        {
            List<Expense> expensesByDate = GetExpensesFromTo(from, to);
            int sum = 0;
            int counter = 0;
            foreach (Expense expense in expensesByDate)
            {
                sum += expense.Value;
                counter++;
            }
            if (counter == 0)
                return 0;
            return sum / counter;
        }
        public Profit? GetProfitBySum(int sum)
        {
            foreach(Profit profit in profits)
            {
                if(profit.Value == sum)
                    return profit;
            }
            return null;
        }
        public Profit? GetProfitByDate(Time time)
        {
            foreach (Profit profit in profits)
            {
                if (profit.Time == time)
                    return profit;
            }
            return null;
        }
        public Profit? GetProfitByCategory(Category category)
        {
            foreach (Profit profit in profits)
            {
                if (profit.HasCategory(category))
                    return profit;
            }
            return null;
        }
        public Expense? GetExpenseBySum(int sum)
        {
            foreach (Expense expense in expenses)
            {
                if (expense.Value == sum)
                    return expense;
            }
            return null;
        }
        public Expense? GetExpenseByDate(Time time)
        {
            foreach (Expense expense in expenses)
            {
                if (expense.Time == time)
                    return expense;
            }
            return null;
        }
        public Expense? GetExpenseByCategory(Category category)
        {
            foreach (Expense expense in expenses)
            {
                if (expense.HasCategory(category))
                    return expense;
            }
            return null;
        }
        //public IEnumerator<Profit> GetEnumerator()
        //{
        //    return profits.GetEnumerator();
        //}
        //IEnumerator<Expense> IEnumerable<Expense>.GetEnumerator()
        //{
        //    return expenses.GetEnumerator();
        //}
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
    }
}
