﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// implementa oprerações aritméticas.
    /// </summary>
    internal static class aritmetica
    {
        /// <summary>
        /// Operação de soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>
        public static int somar(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Operação de subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números.</returns>
        public static int subtrair(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operação de multiplicação.
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int multiplicar(int x, int y)
        {
            return x * y;
        }
    }

}
