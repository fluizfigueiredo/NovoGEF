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

namespace NovoGEF.Database
{
    /// <summary>
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de atividades (geftb003).
    /// </summary>
    public class AtividadeContext
    {
        /// <summary>
        /// Busca atividades conforme o status de ativo/inativo.
        /// </summary>
        /// <param name="ativo">Indica se busca atividades ativas (0) ou inativas (1).</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable Search(int ativo, DataTable dt)
        {
            SqlConnection con = new SqlConnection(Conn.strConn);

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(null, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "sp_buscar_geftb003";
                da.SelectCommand.Parameters.AddWithValue("@ativo", ativo);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha no banco de dados ao buscar os dados. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }finally
            {
                con.Close();
            }
            return dt;
        }

        /// <summary>
        /// Busca horários de atividades pela sigla.
        /// </summary>
        /// <param name="sigla">Sigla da atividade.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchHorario(string sigla, DataTable dt)
        {
            SqlConnection con = new SqlConnection(Conn.strConn);

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(null, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "sp_buscar_horario_geftb003";
                da.SelectCommand.Parameters.AddWithValue("@sigla", sigla);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha no banco de dados ao buscar os dados. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        /// <summary>
        /// Atualiza os dados de uma atividade no banco de dados.
        /// </summary>
        /// <param name="codigo">Código da atividade.</param>
        /// <param name="dtini">Data de início.</param>
        /// <param name="dtfim">Data de fim.</param>
        /// <param name="sigla">Sigla da atividade.</param>
        /// <param name="descricao">Descrição da atividade.</param>
        /// <param name="hrini">Hora de início.</param>
        /// <param name="hrfim">Hora de fim.</param>
        /// <param name="grupo">Grupo da atividade.</param>
        /// <param name="subgrupo">Subgrupo da atividade.</param>
        /// <param name="diasemana">Dia da semana.</param>
        /// <param name="periodo">Período.</param>
        /// <param name="dtgravacao">Data de gravação.</param>
        /// <returns>DataTable preenchido com os dados da atividade atualizada.</returns>
        public DataTable Update(int codigo, string dtini, string dtfim, string sigla, string descricao, string hrini, string hrfim, string grupo, string subgrupo, string diasemana, string periodo, string dtgravacao)
        {
            var dt = new DataTable();
            SqlConnection con = new SqlConnection(Conn.strConn);

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(null, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "sp_atualizar_geftb003";
                da.SelectCommand.Parameters.AddWithValue("@id_atividade", codigo);
                da.SelectCommand.Parameters.AddWithValue("@dt_ini", dtini);
                da.SelectCommand.Parameters.AddWithValue("@dt_fim", dtfim);
                da.SelectCommand.Parameters.AddWithValue("@sigla", sigla);
                da.SelectCommand.Parameters.AddWithValue("@descricao", descricao);
                da.SelectCommand.Parameters.AddWithValue("@grupo", grupo);
                da.SelectCommand.Parameters.AddWithValue("@subgrupo", subgrupo);
                da.SelectCommand.Parameters.AddWithValue("@diasemana", diasemana);
                da.SelectCommand.Parameters.AddWithValue("@periodo", periodo);
                da.SelectCommand.Parameters.AddWithValue("@hr_ini", hrini);
                da.SelectCommand.Parameters.AddWithValue("@hr_fim", hrfim);
                da.SelectCommand.Parameters.AddWithValue("@dt_gravacao", dtgravacao);
                da.SelectCommand.Parameters.AddWithValue("@geftb001_usuario_id_usuario", ParmGlobal.usuarioId);
                da.Fill(dt); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Houve uma falha no banco de dados ao alterar os dados. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }finally
            {
                con.Close();
            }
            return dt;
        }

        /// <summary>
        /// Insere uma nova atividade no banco de dados.
        /// </summary>
        /// <param name="dtini">Data de início.</param>
        /// <param name="sigla">Sigla da atividade.</param>
        /// <param name="descricao">Descrição da atividade.</param>
        /// <param name="hrini">Hora de início.</param>
        /// <param name="hrfim">Hora de fim.</param>
        /// <param name="grupo">Grupo da atividade.</param>
        /// <param name="subgrupo">Subgrupo da atividade.</param>
        /// <param name="diasemana">Dia da semana.</param>
        /// <param name="periodo">Período.</param>
        /// <param name="dtgravacao">Data de gravação.</param>
        /// <returns>DataTable preenchido com os dados da atividade inserida.</returns>
        public DataTable Insert(string dtini, string sigla, string descricao, string hrini, string hrfim, string grupo, string subgrupo, string diasemana, string periodo, string dtgravacao)
        {
            var dt = new DataTable();
            SqlConnection con = new SqlConnection(Conn.strConn);

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(null, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "sp_inserir_geftb003";
                da.SelectCommand.Parameters.AddWithValue("@sigla", sigla);
                da.SelectCommand.Parameters.AddWithValue("@descricao", descricao);
                da.SelectCommand.Parameters.AddWithValue("@grupo", grupo);
                da.SelectCommand.Parameters.AddWithValue("@subgrupo", subgrupo);
                da.SelectCommand.Parameters.AddWithValue("@hr_ini", hrini);
                da.SelectCommand.Parameters.AddWithValue("@hr_fim", hrfim);
                da.SelectCommand.Parameters.AddWithValue("@dt_ini", dtini);
                da.SelectCommand.Parameters.AddWithValue("@diasemana", diasemana);
                da.SelectCommand.Parameters.AddWithValue("@periodo", periodo);
                da.SelectCommand.Parameters.AddWithValue("@dt_gravacao", dtgravacao);
                da.SelectCommand.Parameters.AddWithValue("@geftb001_usuario_id_usuario", ParmGlobal.usuarioId);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve uma falha no banco de dados ao alterar os dados. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
