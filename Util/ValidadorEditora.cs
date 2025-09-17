using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoGEF.Util
{
    /// <summary>
    /// Fornece métodos para validação de dados relacionados à Editora.
    /// </summary>
    public static class ValidadorEditora
    {
        /// <summary>
        /// Valida se o CNPJ informado é válido conforme as regras de cálculo dos dígitos verificadores.
        /// </summary>
        /// <param name="cnpj">CNPJ a ser validado.</param>
        /// <returns>True se o CNPJ for válido; caso contrário, false.</returns>
        public static bool ValidarCNPJ(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
            if (cnpj.Length != 14 || cnpj.Distinct().Count() == 1)
                return false;
            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            string digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}
