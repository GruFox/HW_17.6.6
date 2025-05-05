using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public class Interest
{
    public IInterestState InterestState { get; set; }

    public Interest(IInterestState interestState)
    {
        InterestState = interestState;
    }

    /// <summary>
    /// Рассчитывает процентную ставку пользователя
    /// </summary>
    /// <param name="account"></param>
    public void CalculateInterest(IAccount account)
    {
        InterestState.CalculateInterest(this, account);
    }
}
