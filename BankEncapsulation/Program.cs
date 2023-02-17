namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            Console.WriteLine($"Current Balance is: {bankAccount.GetBalance()}");
            Console.WriteLine("How much would you like to deposit?");
            Double.TryParse(Console.ReadLine(), out var usermoney);

            bankAccount.Deposit(usermoney);
            Console.WriteLine($"Current balance is now: {bankAccount.GetBalance()}");
        }
    }
}
