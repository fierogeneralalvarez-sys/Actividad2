using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class MetodoRecursividad
    {
        public int FactorialRecursividad(int factorial)
        {
            if (factorial == 1)
            {
                return 1;
            }
            else
            {
                return factorial * FactorialRecursividad(factorial - 1);
            }
            
        }
    }
}
