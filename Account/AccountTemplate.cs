namespace Module17Patterns.Account
{
    public abstract class AccountTemplate: IAccount
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public virtual void CalculateInterest() { }
    }
}
