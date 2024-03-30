namespace Module17Patterns.Account
{
    internal class UsualAccount : AccountTemplate, IAccount
    {
        public override void CalculateInterest()
        {   
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;
        }

        public UsualAccount(double _balance)
        {
            Balance = _balance;
            Type = "обычный";
        }
    }
}
