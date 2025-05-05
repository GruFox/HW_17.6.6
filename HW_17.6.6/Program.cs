namespace HW_17._6._6;

internal class Program
{
    static void Main(string[] args)
    {
        IAccount account = new Account() { Type = "Обычный", Balance = 100 };

        account.Calculation(new CalculateInterest());
    }
}
