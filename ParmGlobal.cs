using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoGEF
{
    /// <summary>
    /// Classe que armazena variáveis globais utilizadas em todo o sistema NovoGEF.
    /// </summary>
    class ParmGlobal
    {
        /// <summary>
        /// Identificador de tipo ou dependente.
        /// </summary>
        public static int titoudep;

        /// <summary>
        /// Classificação do associado ou usuário.
        /// </summary>
        public static int classificacao;

        /// <summary>
        /// Situação do associado ou usuário.
        /// </summary>
        public static int situacao;

        /// <summary>
        /// Identificador do usuário logado.
        /// </summary>
        public static int usuarioId;

        /// <summary>
        /// Identificador do associado.
        /// </summary>
        public static int idassociado;

        /// <summary>
        /// Indica se é a primeira vez de acesso.
        /// </summary>
        public static int privez;

        /// <summary>
        /// Nível de acesso do usuário.
        /// </summary>
        public static int nivel;

        /// <summary>
        /// Tipo do associado ou usuário.
        /// </summary>
        public static string tipo;

        /// <summary>
        /// Nome do usuário logado.
        /// </summary>
        public static string usuarioNome;

        /// <summary>
        /// Título do relatório ou tela.
        /// </summary>
        public static string Titulo;

        /// <summary>
        /// Nome do arquivo gerado para relatórios.
        /// </summary>
        public static string nomeArquivo;

        /// <summary>
        /// Caminho base do diretório do aplicativo.
        /// </summary>
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

        /// <summary>
        /// Caminho do arquivo de logo utilizado nos relatórios.
        /// </summary>
        public static string caminhoLogo = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"imagens\GEF_LOGO1.PNG";

        /// <summary>
        /// Array de informações relacionadas ao domingo.
        /// </summary>
        public static string[] domingo = new string[5];

        /// <summary>
        /// Array de dados do associado selecionado.
        /// </summary>
        public static string[] dados_associado = new string[4];
    }
}
