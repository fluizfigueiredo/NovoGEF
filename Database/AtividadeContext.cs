using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovoGEF.Models;
using NovoGEF.Util;

namespace NovoGEF.Database
{
    /// <summary>
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de atividades (geftb003).
    /// </summary>
    public class AtividadeContext
    {
        private readonly string connectionString = Conn.StrConn;

        /// <summary>
        /// Busca atividades conforme o status de ativo/inativo.
        /// </summary>
        /// <param name="ativo">Indica se busca atividades ativas (0) ou inativas (1).</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public string Search(int ativo, Atividade atividade)
        {
            var sql = "";
            if (ativo == 0)
            {
                sql =   "SELECT id_atividade, sigla, descricao, grupo, subgrupo, " +
                        "hr_ini, hr_fim, dt_ini, dt_fim, diasemana, periodo, " +
                        "dt_gravacao, geftb001_usuario_id_usuario " +
                	    "FROM geftb003_atividade WHERE dt_fim IS NULL;"
            }
            else
            {
                sql =   "SELECT id_atividade, sigla, descricao, grupo, subgrupo, " +
                        "hr_ini, hr_fim, dt_ini, dt_fim, diasemana, periodo, " +
                        "dt_gravacao, geftb001_usuario_id_usuario " +
                        "FROM geftb003_atividade WHERE dt_fim IS NOT NULL;"
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                 return "";
            }
            catch (Exception ex)
            {
                return "Houve uma falha no banco de dados ao alterar os dados do associado. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace;
            }
        }

        /// <summary>
        /// Busca horários de atividades pela sigla.
        /// </summary>
        /// <param name="sigla">Sigla da atividade.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public string SearchHorario(Atividade atividade)
        {
            var sql = "SELECT hr_ini FROM geftb003_atividade WHERE sigla = @sigla;;"
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@sigla", atividade.Sigla);
                        cmd.ExecuteNonQuery();
                    }
                }
                 return "";
            }
            catch (Exception ex)
            {
                return "Houve uma falha no banco de dados ao alterar os dados do associado. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace;
            }
        }

        /// <summary>
        /// Atualiza os dados de uma atividade no banco de dados.
        /// </summary>
        /// <param name="atividade">Objeto Atividade a ser inserido.</param>
        /// <returns>DataTable preenchido com os dados da atividade atualizada.</returns>
        public string Update(Atividade atividade)
        {
            var sql = "	UPDATE [dbo].[geftb003_atividade] SET " +
							"sigla = UPPER(@sigla), " +
							"descricao = UPPER(@descricao), " +
							"grupo = UPPER(@grupo), " +
							"subgrupo = UPPER(@subgrupo), " +
							"hr_ini = @hr_ini, " +
							"hr_fim = @hr_fim, " +
							"dt_ini = @dt_ini, " +
							"dt_fim = @dt_fim, " +
							"diasemana = UPPER(@diasemana), " +
							"periodo = UPPER(@periodo), " +
							"dt_gravacao = @dt_gravacao, " +
							"geftb001_usuario_id_usuario = @geftb001_usuario_id_usuario " +
                        	"WHERE id_atividade = @id_atividade;"
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id_atividade", atividade.Id_Atividade);
                        cmd.Parameters.AddWithValue("@dt_ini", atividade.Dt_Ini);
                        cmd.Parameters.AddWithValue("@dt_fim", atividade.Dt_Fim);
                        cmd.Parameters.AddWithValue("@sigla", atividade.Sigla);
                        cmd.Parameters.AddWithValue("@descricao", atividade.Descricao);
                        cmd.Parameters.AddWithValue("@grupo", atividade.Grupo);
                        cmd.Parameters.AddWithValue("@subgrupo", atividade.SubGrupo);
                        cmd.Parameters.AddWithValue("@diasemana", atividade.DiaSemana);
                        cmd.Parameters.AddWithValue("@periodo", atividade.Periodo);
                        cmd.Parameters.AddWithValue("@hr_ini", atividade.Hr_Ini);
                        cmd.Parameters.AddWithValue("@hr_fim", atividade.Hr_Fim);
                        cmd.Parameters.AddWithValue("@dt_gravacao", atividade.Dt_Gravacao);
                        cmd.Parameters.AddWithValue("@geftb001_usuario_id_usuario", atividade.Geftb001_Id_Usuario);
                        cmd.ExecuteNonQuery();
                    }
                }
                 return "";
            }
            catch (Exception ex)
            {
                return "Houve uma falha no banco de dados ao alterar os dados do associado. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace;
            }
       }

        /// <summary>
        /// Insere uma nova atividade no banco de dados.
        /// </summary>
        /// <param name="atividade">Objeto Atividade a ser inserido.</param>
        /// <returns>DataTable preenchido com os dados da atividade inserida.</returns>
        public string Insert(Atividade atividade)
        {
            var sql = "INSERT INTO geftb003_atividade ( " +
                        "id_atividade, " +
                        "sigla, " +
                        "descricao, " +
                        "grupo, " +
                        "subgrupo, " +
                        "hr_ini, " +
                        "hr_fim, " +
                        "dt_ini, " +
                        "diasemana, " +
                        "periodo, " +
                        "dt_gravacao, " +
                        "geftb001_usuario_id_usuario) " +
                    "VALUES ( " +
                        "NEXT VALUE FOR dbo.geftb003_atividade_idatividade_seq, " +
                        "UPPER(@sigla), " +
                        "UPPER(@descricao), " +
                        "UPPER(@grupo), " +
                        "UPPER(@subgrupo), " +
                        "@hr_ini, " +
                        "@hr_fim, " +
                        "@dt_ini, " +
                        "UPPER(@diasemana), " +
                        "UPPER(@periodo), " +
                        "@dt_gravacao, " +
                        "@geftb001_usuario_id_usuario);"
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id_atividade", atividade.Id_Atividade);
                        cmd.Parameters.AddWithValue("@dt_ini", atividade.Dt_Ini);
                        cmd.Parameters.AddWithValue("@dt_fim", atividade.Dt_Fim);
                        cmd.Parameters.AddWithValue("@sigla", atividade.Sigla);
                        cmd.Parameters.AddWithValue("@descricao", atividade.Descricao);
                        cmd.Parameters.AddWithValue("@grupo", atividade.Grupo);
                        cmd.Parameters.AddWithValue("@subgrupo", atividade.SubGrupo);
                        cmd.Parameters.AddWithValue("@diasemana", atividade.DiaSemana);
                        cmd.Parameters.AddWithValue("@periodo", atividade.Periodo);
                        cmd.Parameters.AddWithValue("@hr_ini", atividade.Hr_Ini);
                        cmd.Parameters.AddWithValue("@hr_fim", atividade.Hr_Fim);
                        cmd.Parameters.AddWithValue("@dt_gravacao", atividade.Dt_Gravacao);
                        cmd.Parameters.AddWithValue("@geftb001_usuario_id_usuario", atividade.Geftb001_Id_Usuario);
                        cmd.ExecuteNonQuery();
                    }
                }
                 return "";
            }
            catch (Exception ex)
            {
                return "Houve uma falha no banco de dados ao alterar os dados do associado. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace;
            }
        }
    }
}
