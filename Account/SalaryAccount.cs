namespace Module17Patterns.Account
{
    internal class SalaryAccount : AccountTemplate, IAccount
    {
        public override void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }

        public SalaryAccount(double _balance)
        {
            Type = "зарплатный";
            Balance = _balance;
        }
    }
}
