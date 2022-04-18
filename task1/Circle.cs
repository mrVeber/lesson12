using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    static class Circle
    {
        static public double GetCircumference (double r)
        {
            return 2 * Math.PI * r;
        }

        static public double GetAreaOfACircle (double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        static public string GetOwnershipChek (double r, double x, double y)
        {
            double h = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (h > r)
            {
                return "Точка не принадлежит окружности!";
            }
            return "Точка принадлежит окружности!";
        }
    }
}
