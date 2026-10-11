using System;
using System.Collections.Generic;
using System.Text;

namespace Loja_de_Informatica_NET10
{
    internal static class Utilitarios
    {
        internal static string somenteNumeros(string texto)
        {
            string numeros = "";

            foreach (char caractere in texto)
            {
                if (caractere >= '0' && caractere <= '9')
                {
                    numeros += caractere;
                }
            }
            return numeros;
        }
    }
}
