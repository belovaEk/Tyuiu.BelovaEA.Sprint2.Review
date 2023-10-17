using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BelovaEA.Sprint2.TaskReview.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (y >= 0 && y <= 0.5 && Math.Sin(x) >= y)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
