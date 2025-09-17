using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoGEF.Database
{
    /// <summary>
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de livros da livraria (geftb012).
    /// </summary>
    internal class Geftb012
    {
        /// <summary>
        /// Busca todos os registros de livros da livraria.
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
                da.SelectCommand.CommandText = "sp_buscar_geftb012";
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
        /// Busca registros de livros pelo código.
        /// </summary>
        /// <param name="codigo">Código do livro.</param>
        /// <param name="dt">DataTable para preenchimento dos dados encontrados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchCodigo(int codigo, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_codigo_geftb012";
                da.SelectCommand.Parameters.AddWithValue("@id_livraria", codigo);
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
        /// Busca registros de livros pelo título.
        /// </summary>
        /// <param name="titulo">Título do livro.</param>
        /// <param name="dt">DataTable para preenchimento dos dados encontrados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchTitulo(string titulo, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_titulo_geftb012";
                da.SelectCommand.Parameters.AddWithValue("@titulo", titulo);
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
        /// Busca registros de livros pelo assunto.
        /// </summary>
        /// <param name="assunto">Assunto do livro.</param>
        /// <param name="dt">DataTable para preenchimento dos dados encontrados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchAssunto(string assunto, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_assunto_geftb012";
                da.SelectCommand.Parameters.AddWithValue("@assunto", assunto);
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
        /// Atualiza os dados de um livro da livraria.
        /// </summary>
        /// <param name="idlivraria">Id do livro.</param>
        /// <param name="titulo">Título do livro.</param>
        /// <param name="assunto">Assunto do livro.</param>
        /// <param name="autor">Id do autor.</param>
        /// <param name="autoresp">Id do autor espiritual.</param>
        /// <param name="editora">Id da editora.</param>
        /// <param name="estoque">Quantidade em estoque.</param>
        /// <param name="vlunitario">Valor unitário.</param>
        /// <param name="vllivraria">Valor para livraria.</param>
        /// <param name="vlfeira">Valor para feira.</param>
        /// <param name="dtgravacao">Data de gravação da alteração.</param>
        /// <returns>DataTable preenchido com os dados atualizados.</returns>
        public DataTable Update(int idlivraria, string titulo, string assunto, int autor, int autoresp, int editora, int estoque, decimal vlunitario, decimal vllivraria, decimal vlfeira, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_atualizar_geftb012";
                da.SelectCommand.Parameters.AddWithValue("@id_livraria", idlivraria);
                da.SelectCommand.Parameters.AddWithValue("@titulo", titulo);
                da.SelectCommand.Parameters.AddWithValue("@assunto", assunto);
                da.SelectCommand.Parameters.AddWithValue("@autor", autor);
                da.SelectCommand.Parameters.AddWithValue("@autoresp", autoresp);
                da.SelectCommand.Parameters.AddWithValue("@editora", editora);
                da.SelectCommand.Parameters.AddWithValue("@estoque", estoque);
                da.SelectCommand.Parameters.AddWithValue("@vl_unitario", vlunitario);
                da.SelectCommand.Parameters.AddWithValue("@vl_livraria", vllivraria);
                da.SelectCommand.Parameters.AddWithValue("@vl_feira", vlfeira);
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
        /// Insere um novo livro na livraria.
        /// </summary>
        /// <param name="titulo">Título do livro.</param>
        /// <param name="assunto">Assunto do livro.</param>
        /// <param name="autor">Id do autor.</param>
        /// <param name="autoresp">Id do autor espiritual.</param>
        /// <param name="editora">Id da editora.</param>
        /// <param name="estoque">Quantidade em estoque.</param>
        /// <param name="vlunitario">Valor unitário.</param>
        /// <param name="vllivraria">Valor para livraria.</param>
        /// <param name="vlfeira">Valor para feira.</param>
        /// <param name="dtgravacao">Data de gravação da inclusão.</param>
        /// <returns>DataTable preenchido com os dados inseridos.</returns>
        public DataTable Insert(string titulo, string assunto, int autor, int autoresp, int editora, int estoque, decimal vlunitario, decimal vllivraria, decimal vlfeira, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_inserir_geftb012";
                da.SelectCommand.Parameters.AddWithValue("@titulo", titulo);
                da.SelectCommand.Parameters.AddWithValue("@assunto", assunto);
                da.SelectCommand.Parameters.AddWithValue("@autoresp", autoresp);
                da.SelectCommand.Parameters.AddWithValue("@autor", autor);
                da.SelectCommand.Parameters.AddWithValue("@editora", editora);
                da.SelectCommand.Parameters.AddWithValue("@estoque", estoque);
                da.SelectCommand.Parameters.AddWithValue("@vl_unitario", vlunitario);
                da.SelectCommand.Parameters.AddWithValue("@vl_livraria", vllivraria);
                da.SelectCommand.Parameters.AddWithValue("@vl_feira", vlfeira);
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
