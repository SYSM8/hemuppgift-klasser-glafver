namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jane", "Smith");
            employee.Salary = 3000;
            Console.WriteLine($"Annual Salary: {employee.GetAnnualSalary()}");
            employee.GiveRaise(10);
            Console.WriteLine($"New Monthly Salary: {employee.Salary}");
            Console.WriteLine($"New Annual Salary: {employee.GetAnnualSalary()}");

            Console.WriteLine("\n");

            BankAccount account = new BankAccount("123456789", "John Doe", 1000);
            account.Deposit(500);
            account.Withdraw(200);
            account.DisplayBalance();

            Console.WriteLine("\n");

            BankAccount account_007 = new BankAccount("777", "James Bond", 2000);
            account_007.Deposit(5000);
            account_007.Withdraw(10000);
            account_007.DisplayBalance();
        }
    }
}
