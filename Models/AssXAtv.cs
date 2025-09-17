using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoGEF.Models
{
    /// <summary>
    /// Representa a associação entre um associado e uma atividade, incluindo datas de início e fim, usuário responsável e data de gravação.
    /// </summary>
    public class AssxAtv
    {
        /// <summary>
        /// Identificador da associação entre associado e atividade.
        /// </summary>
        public int Id_AssXAtv { get; set; }

        /// <summary>
        /// Identificador do associado.
        /// </summary>
        public int Geftb002_Id_Associado { get; set; }

        /// <summary>
        /// Identificador da atividade.
        /// </summary>
        public int Geftb003_Id_Atividade { get; set; }

        /// <summary>
        /// Data de início da associação.
        /// </summary>
        public DateTime Dt_Ini { get; set; }

        /// <summary>
        /// Data de término da associação.
        /// </summary>
        public DateTime Dt_Fim { get; set; }

        /// <summary>
        /// Identificador do usuário responsável pela gravação.
        /// </summary>
        public int Geftb001_Id_Usuario { get; set; }

        /// <summary>
        /// Data de gravação da associação.
        /// </summary>
        public DateTime Dt_Gravacao { get; set; }
    }
}
