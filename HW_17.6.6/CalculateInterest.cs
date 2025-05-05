using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public class CalculateInterest : ICalculator
{
    // Метод для расчета процентной ставки
    public void Calculation(IAccount account)
    {
        if (account.Type == "Обычный")
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            Interest interest = new Interest(new BaseInterestState());
            interest.CalculateInterest(account);
        }
        else if (account.Type == "Зарплатный")
        {
            //расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
            Console.WriteLine($"С учетом Вашей учетной записи Ваша процентная ставка равна {account.Interest}");
        }
    }
}
