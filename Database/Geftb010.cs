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
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de autores (geftb010).
    /// </summary>
    internal class Geftb010
    {
        /// <summary>
        /// Busca todos os registros de autores.
        /// </summary>
        /// <param name="dt">DataTable para preenchimento dos dados encontrados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable Search(DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_geftb010";
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
        /// Busca registros de autores pelo nome.
        /// </summary>
        /// <param name="nomeautor">Nome do autor.</param>
        /// <param name="dt">DataTable para preenchimento dos dados encontrados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchNome(string nomeautor, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_nome_geftb010";
                da.SelectCommand.Parameters.AddWithValue("@nomeautor", nomeautor);
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
        /// Atualiza os dados de um autor.
        /// </summary>
        /// <param name="idautor">Id do autor.</param>
        /// <param name="nomeautor">Nome do autor.</param>
        /// <param name="dtgravacao">Data de gravação da alteração.</param>
        /// <returns>DataTable preenchido com os dados atualizados.</returns>
        public DataTable Update(int idautor, string nomeautor, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_atualizar_geftb010";
                da.SelectCommand.Parameters.AddWithValue("@id_autor", idautor);
                da.SelectCommand.Parameters.AddWithValue("@nomeautor", nomeautor);
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
        /// Insere um novo autor.
        /// </summary>
        /// <param name="nomeautor">Nome do autor.</param>
        /// <param name="dtgravacao">Data de gravação da inclusão.</param>
        /// <returns>DataTable preenchido com os dados inseridos.</returns>
        public DataTable Insert(string nomeautor, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_inserir_geftb010";
                da.SelectCommand.Parameters.AddWithValue("@nomeautor", nomeautor);
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
