using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NovoGEF.Util
{
    /// <summary>
    /// Classe utilitária para validação de dados de associados, como e-mail e CPF.
    /// </summary>
    public static class ValidadorAssociado
    {
        /// <summary>
        /// Valida data.
        /// </summary>
        /// <param name="data">data a ser validado.</param>
        /// <returns>Retorna true se válido, false se inválido.</returns>
        public static bool ValidarData(string data, string formato = "dd/MM/yyyy")
        {
            return DateTime.TryParseExact(
                data, 
                formato, 
                System.Globalization.CultureInfo.InvariantCulture, 
                System.Globalization.DateTimeStyles.None, 
                out _);
        }
        /// <summary>
        /// Valida o e-mail informado.
        /// </summary>
        /// <param name="email">E-mail a ser validado.</param>
        /// <returns>Retorna true se válido, false se inválido.</returns>
        public static bool ValidarEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && 
                   email.Contains("@") && 
                   email.Contains(".") && 
                   email.IndexOf("@") < email.LastIndexOf(".");
        }

        /// <summary>
        /// Valida o CPF informado no campo do formulário.
        /// </summary>
        /// <param name="cpf">CPF a ser validado.</param>
        /// <returns>Retorna true se válido, false se inválido.</returns>
        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();
            if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
                return false;
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            string digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
