using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Tools
{
    internal class SquareLayout
    {
        public List<int> GetSquareRootDivisors(int input)
        {
            List<int> divisorList = new();

            for (var i = 4; i <= input; i++)
            {
                if (input % i == 0)
                {
                    if ((Math.Sqrt(i) % 1) == 0)
                    {
                        divisorList.Add(i);
                    }
                }
            }

            return divisorList;
        }
    }
}
