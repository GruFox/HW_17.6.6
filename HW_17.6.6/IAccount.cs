using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_17._6._6;

public interface IAccount
{
    string Type { get; set; }
    double Balance { get; set; }
    double Interest { get; set; }

    /// <summary>
    /// Рассчитывает необходимое значение
    /// </summary>
    /// <param name="calculate"></param>
    void Calculation(ICalculator calculate);
}