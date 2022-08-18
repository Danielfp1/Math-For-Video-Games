using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_For_Video_Games
{
    internal class Remainder
    {

        public int GetRemainder(int numerador, int denominador)
        {
            errorHandler(numerador,denominador);
            int remainder = numerador % denominador;
            return remainder;
        }

        public int GetResult(int numerador, int denominador)
        {
            errorHandler(numerador, denominador);
            int result = numerador / denominador;
            return result;
        }

        public int GetRand()
        {
            Random random = new Random();
            int num = random.Next(1000);
            return num;
        }
        public void errorHandler(int numerador, int denominador)
        {
            if (denominador == 0)
            {
                throw new Exception(string.Format("Turn timer can't be ZERO"));
            }
        }

    }

}
