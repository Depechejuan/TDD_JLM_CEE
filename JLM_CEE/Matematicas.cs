using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLM_CEE
{
    public static class Matematicas
    {
        public static long CalcularFactorial(int n)
        {
            long result = n;
            for (long i = (result - 1); i > 1; i--)
                result *= i;
            return result;
        }

    }
}
