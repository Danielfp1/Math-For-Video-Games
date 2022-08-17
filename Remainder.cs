using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_For_Video_Games
{
    internal class Remainder
    {

        public int GetRemainder(int numerador, int denominador)
        {

            int remainder = numerador % denominador;
            return remainder;
        }

        public int GetResult(int numerador, int denominador)
        {
            int result = numerador / denominador;
            return result;
        }

        public int GetRand()
        {
            Random random = new Random();
            int num = random.Next(1000);
            return num;
        }
    }

}
