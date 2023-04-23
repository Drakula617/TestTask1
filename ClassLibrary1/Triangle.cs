using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle: Figure
    {
        public double A;
        public double B;
        public double C;

        public Triangle(double a, double b, double c)
        {
            if (IsTriangle(a, b, c) == true)
            {
                A = a; B = b; C = c;
            }
            else
            {
                throw new DivideByZeroException("Ошибка: Такого треугольника не существует!");
            }
        }

        /// <summary>
        /// Есть ли такой трегольник
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        bool IsTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            if (a + b > c && a + c > b && b +c > a)
                return true;
            else
                return false;
        }
        public override double FindArea()
        {
            double s = (A + B + C)/2;
            double S = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            return S;
        }

        /// <summary>
        /// Является ли треугольник прямоугольным 
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular() { 
            List<double> ABC = new List<double>() { A,B,C};
            double hypotenuse = ABC.Max();
            //Находим гипотенузу
            ABC.Remove(hypotenuse);
            //Считаем сумму квадратов катетов
            double AB = 0;
            foreach (double item in ABC) {
                AB+= Math.Pow(item,2);
            }
            //Сравниваем по формуле Пифагора
            if (hypotenuse == Math.Sqrt(AB))
                return true;
            else
                return false;
        }
    }
}
