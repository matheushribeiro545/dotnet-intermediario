using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_intermediario.Models
{
    public static class IntExtensions // Método extensivo
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}