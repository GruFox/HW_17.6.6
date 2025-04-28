using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public static class Calculator
{
    // Метод для расчета процентной ставки
    public static void CalculateInterest(Account account)
    {
        if (account.Type == "Обычный")
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;
            Console.WriteLine(account.Interest);

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
        else if (account.Type == "Зарплатный")
        {
            // расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
