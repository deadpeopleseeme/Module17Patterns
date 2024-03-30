namespace Module17Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.InterestSetter(new Account.UsualAccount(_balance: 5000));
            Calculator.InterestSetter(new Account.SalaryAccount(_balance: 5000));
        }
    }
}
