using NovoGEF.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovoGEF.Database;
using NovoGEF.Forms;

namespace NovoGEF.Models
{
    /// <summary>
    /// Representa um associado do sistema, contendo informações pessoais e de vínculo.
    /// </summary>
    public class Associado
    {
        /// <summary>
        /// Identificador único do associado.
        /// </summary>
        public int Id_Associado { get; set; }

        /// <summary>
        /// Matrícula do associado.
        /// </summary>
        public string Matricula { get; set; }

        /// <summary>
        /// Nome completo do associado.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de nascimento do associado.
        /// </summary>
        public string Dt_Nascimento { get; set; }

        /// <summary>
        /// Data de início do vínculo do associado.
        /// </summary>
        public string Dt_Ini { get; set; }

        /// <summary>
        /// Data de término do vínculo do associado.
        /// </summary>
        public string Dt_Fim { get; set; }

        /// <summary>
        /// CPF do associado.
        /// </summary>
        public string Cpf { get; set; }

        /// <summary>
        /// Tel1 do associado.
        /// </summary>
        public string Tel1 { get; set; }

        /// <summary>
        /// Tel2 do associado.
        /// </summary>
        public string Tel2 { get; set; }

        /// <summary>
        /// E-mail do associado.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Endereço do associado.
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Bairro do associado.
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Cidade do associado.
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// CEP do associado.
        /// </summary>
        public string Cep { get; set; }

        /// <summary>
        /// Grau de parentesco, se aplicável.
        /// </summary>
        public string Parentesco { get; set; }

        /// <summary>
        /// Observações adicionais sobre o associado.
        /// </summary>
        public string Obs { get; set; }

        /// <summary>
        /// Identificador do usuário responsável pelo cadastro.
        /// </summary>
        public int Geftb001_Id_Usuario { get; set; }

        /// <summary>
        /// Data de gravação do registro.
        /// </summary>
        public DateTime Dt_Gravacao { get; set; }

        private AssociadoContext _associadoContext = new AssociadoContext(); // Instância da classe Geftb002 para operações de banco de dados.

        /// <summary>
        /// Insere o associado no banco de dados após validação dos dados.
        /// Retorna "ok" se a inserção for bem-sucedida ou uma mensagem de erro caso contrário.
        /// </summary>
        /// <returns>
        /// Uma string "ok" se a inserção for bem-sucedida; caso contrário, uma string contendo as mensagens de erro.
        /// </returns>
        public string Insert()
        {
            var result = Validar();
            if (result == "ok")
                return _associadoContext.Insert(this, ParmGlobal.titoudep);
            else
                return result;
        }
        
        /// <summary>
        /// Altera o associado no banco de dados após validação dos dados.
        /// Retorna "ok" se a inserção for bem-sucedida ou uma mensagem de erro caso contrário.
        /// </summary>
        /// <returns>
        /// Uma string "ok" se a inserção for bem-sucedida; caso contrário, uma string contendo as mensagens de erro.
        /// </returns>
        public string Update()
        {
            var result = Validar();
            if (result == "ok")
                return _associadoContext.Update(this);
            else
                return result;
        }

        /// <summary>
        /// Valida os dados do associado, retornando "ok" se todos os campos obrigatórios estiverem corretos,
        /// ou uma mensagem de erro detalhando os campos inválidos ou ausentes.
        /// </summary>
        /// <returns>
        /// Uma string "ok" se a validação for bem-sucedida; caso contrário, uma string contendo as mensagens de erro.
        /// </returns>
        public string Validar()
        {
            string result = "";
            bool isNumeric_Tel1 = Regex.IsMatch(Tel1, @"^\d+$");
            bool isNumeric_Tel2 = Regex.IsMatch(Tel2, @"^\d+$");
            bool isNumeric_Cep = Regex.IsMatch(Cep, @"^\d+$");

            if (string.IsNullOrWhiteSpace(Nome))

                result += "O campo Nome é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(Matricula))

                result += "O campo Matrícula é obrigatório.\n";

            if (Dt_Nascimento == "01/01/0001" || !ValidadorAssociado.ValidarData(Dt_Nascimento))

                result += "O campo Data de Nascimento é obrigatório.\n";

            if (Dt_Ini == "01/01/0001" || !ValidadorAssociado.ValidarData(Dt_Ini))

                result += "O campo Data de Início é obrigatório.\n";

            if (!string.IsNullOrWhiteSpace(Cpf) && !Util.ValidadorAssociado.ValidarCPF(Cpf))

                result += "O CPF informado é inválido.\n";

            if (!string.IsNullOrWhiteSpace(Email) && !Util.ValidadorAssociado.ValidarEmail(Email))

                result += "O E-mail informado é inválido.\n";

            if (!String.IsNullOrEmpty(Tel1) && !isNumeric_Tel1)

                result += "Campo Telefone 1 deve conter números.";

            if (!String.IsNullOrEmpty(Tel2) && !isNumeric_Tel2)

                result += "Campo Telefone 2 deve conter números.";

            if (!String.IsNullOrEmpty(Cep) && !isNumeric_Cep)

                result += "Campo CEP deve conter números.";

            if (!String.IsNullOrEmpty(Cep) && Cep.Length != 9)

                result += "Campo CEP inválido.";

            if (ParmGlobal.titoudep == 1 && String.IsNullOrEmpty(Matricula))

                result += "Campo matricula do titular não foi informada. Selecione um titular na lista.";

            return result == "" ? "ok" : result;
        }
    }
}
