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
    /// Representa uma atividade registrada no sistema, incluindo informações de identificação, horários, datas, grupo, subgrupo, usuário e período.
    /// </summary>
    public class Atividade
    {
        /// <summary>
        /// Identificador único da atividade.
        /// </summary>
        public int Id_Atividade { get; set; }

        /// <summary>
        /// Sigla da atividade.
        /// </summary>
        public string Sigla { get; set; }

        /// <summary>
        /// Descrição detalhada da atividade.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Grupo ao qual a atividade pertence.
        /// </summary>
        public string Grupo { get; set; }

        /// <summary>
        /// Subgrupo ao qual a atividade pertence.
        /// </summary>
        public string SubGrupo { get; set; }

        /// <summary>
        /// Horário de início da atividade.
        /// </summary>
        public string Hr_Ini { get; set; }

        /// <summary>
        /// Horário de término da atividade.
        /// </summary>
        public string Hr_Fim { get; set; }

        /// <summary>
        /// Data de início da atividade.
        /// </summary>
        public DateTime Dt_Ini { get; set; }

        /// <summary>
        /// Data de término da atividade.
        /// </summary>
        public DateTime Dt_Fim { get; set; }

        /// <summary>
        /// Dia da semana em que a atividade ocorre.
        /// </summary>
        public string DiaSemana { get; set; }

        /// <summary>
        /// Período da atividade.
        /// </summary>
        public string Periodo { get; set; }

        /// <summary>
        /// Identificador do usuário relacionado à atividade.
        /// </summary>
        public int Geftb001_Id_Usuario { get; set; }

        /// <summary>
        /// Data de gravação da atividade.
        /// </summary>
        public DateTime Dt_Gravacao { get; set; }

        private AtividadeContext _atividadeContext = new AtividaddeContext(); // Instância da classe AtividadeContext para operações de banco de dados.

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
                return _atividadeContext.Insert(this);
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
                return _atividadeContext.Update(this);
            else
                return result;
        }

        /// <summary>
        /// Valida os dados da atividade, retornando "ok" se todos os campos obrigatórios estiverem corretos,
        /// ou uma mensagem de erro detalhando os campos inválidos ou ausentes.
        /// </summary>
        /// <returns>
        /// Uma string "ok" se a validação for bem-sucedida; caso contrário, uma string contendo as mensagens de erro.
        /// </returns>
        public string Validar()
        {
            string result = "";
            bool isNumeric_hrini = Regex.IsMatch(Hr_Ini, @"^\d+$");
            bool isNumeric_hrfim = Regex.IsMatch(Hr_Fim, @"^\d+$");

            if (String.IsNullOrEmpty(Sigla))
                result += "Campo sigla não aceita vazio.";

            if (String.IsNullOrEmpty(Descricao))
                result += "Campo descrição não aceita vazio.";

            if (String.IsNullOrEmpty(Hr_Ini))
                result += "Campo hora inicial deve ser preenchido.";

            if (!String.IsNullOrEmpty(Hr_Ini) && !isNumeric_hrini)
                result += "Campo hora inicial deve conter números.";

            if (String.IsNullOrEmpty(Hr_Fim))
                result += "Campo hora final deve ser preenchido.;

            if (!String.IsNullOrEmpty(Hr_Fim) && !isNumeric_hrfim)
                result += "Campo hora final deve conter números.";

            if (rb == 0 && cbSubgrupo2.SelectedIndex == -1)
                result += "Selecione um subgrupo de assitência social.";

            if (rb == 1 && cbSubgrupo1.SelectedIndex == -1)
                result += "Selecione um subgrupo de colaborador.";

            if (String.IsNullOrEmpty(DiaSemana))
                result += "Selecione o dia da semana que a atividade ocorrerá.";

            if (String.IsNullOrEmpty(Periodo))
                result += "selecione o periodo que a atividade ocorrerá.";


            return result == "" ? "ok" : result;
        }
    }
}
