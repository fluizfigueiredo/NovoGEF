using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
