using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public interface ICalculator
{
    /// <summary>
    /// Реализует расчет необходимого значения
    /// </summary>
    /// <param name="account"></param>
    void Calculation(IAccount account);
}
