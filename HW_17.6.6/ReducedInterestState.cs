using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public class ReducedInterestState : IInterestState
{
    public void CalculateInterest(Interest interest, IAccount account)
    {
        account.Interest -= account.Balance * 0.2;
        Console.WriteLine($"С учетом Вашей учетной записи и баланса Ваша процентная ставка равна {account.Interest}");
    }
}
