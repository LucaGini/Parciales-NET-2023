using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gini.Negocio
{
    public class Validaciones
    {
        public static bool EsMailValido(string Email)
        {
            string patron = @"^([0-9A-Za-z])+@([0-9A-Za-z])+.([A-Za-z]){2,3}$";

            if (Regex.IsMatch(Email, patron))
            {
                return true;
            }

            return false;
        }
        public static bool vacios(List<String> campos)
        {
            foreach (var c in campos)
            {
                if (String.IsNullOrEmpty(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
