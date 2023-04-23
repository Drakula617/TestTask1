using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Фигура
    /// </summary>
    public abstract class Figure
    {

        /// <summary>
        /// Вычисление площади фигуры. Переопределяется в классах-наследниках
        /// </summary>
        /// <returns></returns>
        public virtual double FindArea()
        {
            return 0;
        }
    }
}
