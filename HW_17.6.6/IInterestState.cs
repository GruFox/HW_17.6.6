using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public interface IInterestState
{
    /// <summary>
    /// Раализует расчет процентной ставки пользователя
    /// </summary>
    /// <param name="interest"></param>
    /// <param name="account"></param>
    void CalculateInterest(Interest interest, IAccount account);
}
