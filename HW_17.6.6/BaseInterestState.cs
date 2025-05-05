using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public class BaseInterestState : IInterestState
{
    public void CalculateInterest(Interest interest, IAccount account)
    {
        if (account.Balance < 1000)
        {
            interest.InterestState = new ReducedInterestState();
            interest.CalculateInterest(account);
        }
        else if (account.Balance >= 1000)
        {
            interest.InterestState = new IncreasedInterestState();
            interest.CalculateInterest(account);
        }
    }
}
