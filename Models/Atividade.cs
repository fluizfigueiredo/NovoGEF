using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
