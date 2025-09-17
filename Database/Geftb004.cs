using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoGEF
{
    /// <summary>
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de associação entre associados e atividades (geftb004).
    /// </summary>
    internal class Geftb004
    {
        /// <summary>
        /// Busca todas as atividades associadas a um associado.
        /// </summary>
        /// <param name="idassociado">Id do associado.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable Search(int idassociado)
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
                da.SelectCommand.CommandText = "sp_buscar_geftb004";
                da.SelectCommand.Parameters.AddWithValue("@id_associado", idassociado);
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
        /// Busca a associação entre um associado e uma atividade específica.
        /// </summary>
        /// <param name="idassociado">Id do associado.</param>
        /// <param name="atv">Id da atividade.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchAssAtv(int idassociado, int atv, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_assatv_geftb004";
                da.SelectCommand.Parameters.AddWithValue("@id_associado", idassociado);
                da.SelectCommand.Parameters.AddWithValue("@geftb003_atividade_id_atividade", atv);
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
        /// Busca associações de atividades sem agenda para um determinado dia da semana.
        /// </summary>
        /// <param name="diasemana">Dia da semana.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchAssAtvsemAgenda(string diasemana, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_assatv_sem_agenda_geftb004";
                da.SelectCommand.Parameters.AddWithValue("@diasemana", diasemana);
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
        /// Atualiza os dados de uma associação entre associado e atividade.
        /// </summary>
        /// <param name="id">Id da associação.</param>
        /// <param name="dtfim">Data de fim da associação.</param>
        /// <param name="dtgravacao">Data de gravação da alteração.</param>
        /// <returns>DataTable preenchido com os dados atualizados.</returns>
        public DataTable Update(int id, string dtfim, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_atualizar_geftb004";
                da.SelectCommand.Parameters.AddWithValue("@id_associado_atividade", id);
                da.SelectCommand.Parameters.AddWithValue("@dt_fim", dtfim);
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

        /// <summary>
        /// Insere uma nova associação entre associado e atividade.
        /// </summary>
        /// <param name="idassociado">Id do associado.</param>
        /// <param name="atv">Id da atividade.</param>
        /// <param name="dtini">Data de início da associação.</param>
        /// <param name="dtfim">Data de fim da associação.</param>
        /// <param name="dtgravacao">Data de gravação da inclusão.</param>
        /// <returns>DataTable preenchido com os dados inseridos.</returns>
        public DataTable Insert(int idassociado, int atv, string dtini, string dtfim, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_inserir_geftb004";
                da.SelectCommand.Parameters.AddWithValue("@id_associado", idassociado);
                da.SelectCommand.Parameters.AddWithValue("@geftb003_atividade_id_atividade", atv);
                da.SelectCommand.Parameters.AddWithValue("@dt_ini", dtini);
                da.SelectCommand.Parameters.AddWithValue("@dt_fim", dtfim);
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
