
using Module17Patterns.Account;

namespace Module17Patterns
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void InterestSetter(AccountTemplate account)
        {
            account.CalculateInterest();
            Console.WriteLine($"Тип аккаунта: {account.Type}, ставка: {account.Interest}");
        }
    }
}
