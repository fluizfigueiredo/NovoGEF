using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace NovoGEF
{
    /// <summary>
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de usuários (geftb001).
    /// </summary>
    public class Geftb001
    {
        /// <summary>
        /// Realiza a busca de usuário no banco de dados utilizando matrícula e senha.
        /// </summary>
        /// <param name="matricula">Matrícula do usuário.</param>
        /// <param name="senha">Senha do usuário.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados do usuário encontrado.</returns>
        public DataTable Search(string matricula, string senha, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_validar_usuario_geftb001";
                da.SelectCommand.Parameters.AddWithValue("@matricula", matricula);
                da.SelectCommand.Parameters.AddWithValue("@senha", senha);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve uma falha no banco de dados ao buscar os dados. Por favor entre em contato com o administrador do sistema. " + e.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        /// <summary>
        /// Busca usuários pelo id ou matrícula.
        /// </summary>
        /// <param name="id_usuario">Id do usuário.</param>
        /// <param name="matricula">Matrícula do usuário.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados dos usuários encontrados.</returns>
        public DataTable SearchUsuario(int id_usuario, string matricula, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_usuario_geftb001";
                da.SelectCommand.Parameters.AddWithValue("@matricula", matricula);
                da.SelectCommand.Parameters.AddWithValue("@id_usuario", id_usuario);
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
        /// Busca todos os usuários pelo nome.
        /// </summary>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados dos usuários encontrados.</returns>
        public DataTable SearchUsuarioNome(DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_geftb001";
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
        /// Busca o nível de acesso do usuário pelo id.
        /// </summary>
        /// <param name="id_usuario">Id do usuário.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com o nível do usuário.</returns>
        public DataTable SearchUsuarioNivel(int id_usuario, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_nivel_usuario_geftb001";
                da.SelectCommand.Parameters.AddWithValue("@id_usuario", id_usuario);
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
        /// Insere um novo usuário no banco de dados.
        /// </summary>
        /// <param name="senha">Senha do usuário.</param>
        /// <param name="matricula">Matrícula do usuário.</param>
        /// <param name="dt2">Data de início.</param>
        /// <param name="nivel">Nível de acesso do usuário.</param>
        /// <param name="dt4">Data de gravação.</param>
        /// <returns>DataTable preenchido com os dados do usuário inserido.</returns>
        public DataTable Insert(string senha, string matricula, string dt2, int nivel, string dt4)
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
                da.SelectCommand.CommandText = "sp_inserir_geftb001";
                da.SelectCommand.Parameters.AddWithValue("@matricula", matricula);
                da.SelectCommand.Parameters.AddWithValue("@senha", senha);
                da.SelectCommand.Parameters.AddWithValue("@dt_ini", dt2);
                da.SelectCommand.Parameters.AddWithValue("@dt_gravacao", dt4);
                da.SelectCommand.Parameters.AddWithValue("@nivel", nivel);
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
        /// Atualiza os dados de um usuário no banco de dados.
        /// </summary>
        /// <param name="id_usuario">Id do usuário.</param>
        /// <param name="dt2">Data de início.</param>
        /// <param name="dt3">Data de fim.</param>
        /// <param name="nivel">Nível de acesso do usuário.</param>
        /// <param name="dt4">Data de gravação.</param>
        /// <returns>DataTable preenchido com os dados do usuário atualizado.</returns>
        public DataTable Update(int id_usuario, string dt2, string dt3, int nivel, string dt4)
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
                da.SelectCommand.CommandText = "sp_atualizar_geftb001";
                da.SelectCommand.Parameters.AddWithValue("@id_usuario", id_usuario);
                da.SelectCommand.Parameters.AddWithValue("@dt_ini", dt2);
                da.SelectCommand.Parameters.AddWithValue("@dt_fim", dt3);
                da.SelectCommand.Parameters.AddWithValue("@nivel", nivel);
                da.SelectCommand.Parameters.AddWithValue("@dt_gravacao", dt4);
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
        /// Atualiza a senha de um usuário no banco de dados.
        /// </summary>
        /// <param name="matricula">Matrícula do usuário.</param>
        /// <param name="senha">Nova senha do usuário.</param>
        /// <param name="dt4">Data de gravação.</param>
        /// <returns>DataTable preenchido com os dados do usuário atualizado.</returns>
        public DataTable UpdateSenha(string matricula, string senha, string dt4)
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
                da.SelectCommand.CommandText = "sp_atualizar_psw_geftb001";
                da.SelectCommand.Parameters.AddWithValue("@matricula", matricula);
                da.SelectCommand.Parameters.AddWithValue("@senha", senha);
                da.SelectCommand.Parameters.AddWithValue("@dt_gravacao", dt4);
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
    }
}
