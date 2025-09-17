using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NovoGEF.Util
{
    /// <summary>
    /// Classe estática responsável por fornecer a string de conexão com o banco de dados SQL Server.
    /// </summary>
    public static class Conn
    {
        /// <summary>
        /// String de conexão utilizada para acessar o banco de dados 'fabiano' no SQL Server.
        /// </summary>
        private static string _server = "DESKTOP-LT433M5\\SQLEXPRESS"; // Nome do servidor SQL Server
        private static string _database = "fabiano"; // Nome do banco de dados
        private static string _user = "ca"; // Nome do usuário (se aplicável)
        private static string _password = "masterkey"; // Senha do usuário (se aplicável)
        private static string _integratedSecurity = "false"; // Usar autenticação integrada do Windows

        /// <summary>
        /// Obtém a string de conexão SQL Server para o banco de dados 'fabiano'.
        /// </summary>
        public static string StrConn
        {
            get
            {
                return $"Data Source={_server};Initial Catalog={_database};User ID={_user};Password={_password};Integrate Security = {_integratedSecurity}"; // Conexão SQL SERVER com autenticação SQL
            }
        }
    }
}
