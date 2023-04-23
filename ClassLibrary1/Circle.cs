using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle: Figure
    {
        public double Radius { get; set; }


        public override double FindArea()
        { 
            return Math.PI * Radius * Radius;
        }
    }
}
