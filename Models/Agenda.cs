using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovoGEF.Database;
using NovoGEF.Forms;

namespace NovoGEF.Models
{
    /// <summary>
    /// Representa uma agenda de atividades para um associado.
    /// </summary>
    public class Agenda
    {
        /// <summary>
        /// Identificador único da agenda.
        /// </summary>
        public int Id_Agenda { get; set; }

        /// <summary>
        /// Data da agenda.
        /// </summary>
        public DateTime Dt_Agenda { get; set; }

        /// <summary>
        /// Identificador do associado relacionado à agenda.
        /// </summary>
        public int Geftb002_Id_Associado { get; set; }

        /// <summary>
        /// Identificador da atividade relacionada à agenda.
        /// </summary>
        public int Geftb003_Id_Atividade { get; set; }

        /// <summary>
        /// Indica a presença do associado.
        /// </summary>
        public string Presenca { get; set; }

        /// <summary>
        /// Horário de entrada do associado.
        /// </summary>
        public string Hr_Entrada { get; set; }

        /// <summary>
        /// Informações sobre o vestuário do associado.
        /// </summary>
        public string Vestuario { get; set; }

        /// <summary>
        /// Justificativa para ausência ou outra situação.
        /// </summary>
        public string Justificativa { get; set; }

        /// <summary>
        /// Identificador do usuário que gravou a agenda.
        /// </summary>
        public int Geftb001_Id_Usuario { get; set; }

        /// <summary>
        /// Data de gravação da agenda.
        /// </summary>
        public DateTime Dt_Gravacao { get; set; }

        private AgendaContext _agendaContext = new AgendaContext(); // Instância da classe Geftb002 para operações de banco de dados.

        /// <summary>
        /// Insere o agenda no banco de dados após validação dos dados.
        /// Retorna "ok" se a inserção for bem-sucedida ou uma mensagem de erro caso contrário.
        /// </summary>
        /// <returns>
        /// Uma string "ok" se a inserção for bem-sucedida; caso contrário, uma string contendo as mensagens de erro.
        /// </returns>
        public string Insert()
        {
            var result = Validar();
            if (result == "ok")
                return _agendaContext.Insert(this);
            else
                return result;
        }
        
        /// <summary>
        /// Altera o agenda no banco de dados após validação dos dados.
        /// Retorna "ok" se a inserção for bem-sucedida ou uma mensagem de erro caso contrário.
        /// </summary>
        /// <returns>
        /// Uma string "ok" se a inserção for bem-sucedida; caso contrário, uma string contendo as mensagens de erro.
        /// </returns>
        public string Update()
        {
            var result = Validar();
            if (result == "ok")
                return _agendaContext.Update(this);
            else
                return result;
        }

        /// <summary>
        /// Valida os dados da agenda, retornando "ok" se todos os campos obrigatórios estiverem corretos,
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
