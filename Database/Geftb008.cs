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
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de estoque de medicamentos (geftb008).
    /// </summary>
    internal class Geftb008
    {
        /// <summary>
        /// Busca registros de estoque de medicamentos.
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
                da.SelectCommand.CommandText = "sp_buscar_geftb008";
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
        /// Busca registros de recebimento de bolsa (utiliza a mesma procedure de busca de estoque).
        /// </summary>
        /// <param name="dt">DataTable para preenchimento dos dados encontrados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchRecBolsa(DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_geftb008";
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
        /// Atualiza os dados de um medicamento no estoque.
        /// </summary>
        /// <param name="idestoquemed">Id do estoque do medicamento.</param>
        /// <param name="nomecom">Nome comercial do medicamento.</param>
        /// <param name="nomequi">Nome químico do medicamento.</param>
        /// <param name="lote">Número do lote.</param>
        /// <param name="prateleira">Número da prateleira.</param>
        /// <param name="estoque">Quantidade em estoque.</param>
        /// <param name="grfarmaco">Id do grupo de fármaco.</param>
        /// <param name="dtvalidade">Data de validade.</param>
        /// <param name="dtgravacao">Data de gravação da alteração.</param>
        /// <returns>DataTable preenchido com os dados atualizados.</returns>
        public DataTable Update(int idestoquemed, string nomecom, string nomequi, int lote, int prateleira, int estoque, int grfarmaco, string dtvalidade, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_atualizar_geftb008";
                da.SelectCommand.Parameters.AddWithValue("@id_estoquemed", idestoquemed);
                da.SelectCommand.Parameters.AddWithValue("@nomecom", nomecom);
                da.SelectCommand.Parameters.AddWithValue("@nomequi", nomequi);
                da.SelectCommand.Parameters.AddWithValue("@lote", lote);
                da.SelectCommand.Parameters.AddWithValue("@prateleira", prateleira);
                da.SelectCommand.Parameters.AddWithValue("@estoque", estoque);
                da.SelectCommand.Parameters.AddWithValue("@grfarmaco", grfarmaco);
                da.SelectCommand.Parameters.AddWithValue("@dt_validade", dtvalidade);
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
        /// Insere um novo medicamento no estoque.
        /// </summary>
        /// <param name="nomecom">Nome comercial do medicamento.</param>
        /// <param name="nomequi">Nome químico do medicamento.</param>
        /// <param name="lote">Número do lote.</param>
        /// <param name="prateleira">Número da prateleira.</param>
        /// <param name="estoque">Quantidade em estoque.</param>
        /// <param name="grfarmaco">Id do grupo de fármaco.</param>
        /// <param name="dtvalidade">Data de validade.</param>
        /// <param name="dtgravacao">Data de gravação da inclusão.</param>
        /// <returns>DataTable preenchido com os dados inseridos.</returns>
        public DataTable Insert(string nomecom, string nomequi, int lote, int prateleira, int estoque, int grfarmaco, string dtvalidade, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_inserir_geftb008";
                da.SelectCommand.Parameters.AddWithValue("@nomecom", nomecom);
                da.SelectCommand.Parameters.AddWithValue("@nomequi", nomequi);
                da.SelectCommand.Parameters.AddWithValue("@lote", lote);
                da.SelectCommand.Parameters.AddWithValue("@prateleira", prateleira);
                da.SelectCommand.Parameters.AddWithValue("@estoque", estoque);
                da.SelectCommand.Parameters.AddWithValue("@grfarmaco", grfarmaco);
                da.SelectCommand.Parameters.AddWithValue("@dt_validade", dtvalidade);
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
