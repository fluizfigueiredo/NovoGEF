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
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de agenda de atividades (geftb005).
    /// </summary>
    internal class Geftb005
    {
        /// <summary>
        /// Busca registros de agenda pela data informada.
        /// </summary>
        /// <param name="DtAgenda">Data da agenda.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable Search(string DtAgenda, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_geftb005";
                da.SelectCommand.Parameters.AddWithValue("@dt_agenda", DtAgenda);
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
        /// Busca registros de associados vinculados à agenda.
        /// </summary>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchAssAgenda(DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_assagenda_geftb005";
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
        /// Busca datas de agenda para uma atividade específica.
        /// </summary>
        /// <param name="id_atividade">Id da atividade.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com as datas encontradas.</returns>
        public DataTable SearchDtsAgenda(int id_atividade, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_dtsagenda_geftb005";
                da.SelectCommand.Parameters.AddWithValue("@id_atividade", id_atividade);
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
        /// Busca registros de recebimento de bolsa pela data da agenda.
        /// </summary>
        /// <param name="DtAgenda">Data da agenda.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchRecBolsa(string DtAgenda, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_buscar_recbolsa_geftb005";
                da.SelectCommand.Parameters.AddWithValue("@dt_agenda", DtAgenda);
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
        /// Busca registros de presença em atividade para uma data e atividade específica.
        /// </summary>
        /// <param name="DtAgenda">Data da agenda.</param>
        /// <param name="idatividade">Id da atividade.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchPresAtv(string DtAgenda, int idatividade, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_rel_agenda_atividade_freq_geftb005";
                da.SelectCommand.Parameters.AddWithValue("@dt_agenda", DtAgenda);
                da.SelectCommand.Parameters.AddWithValue("@id_atividade", idatividade);
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
        /// Busca atividades agendadas para uma data específica.
        /// </summary>
        /// <param name="DtAgenda">Data da agenda.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable SearchAgendaAtv(string DtAgenda, DataTable dt)
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
                da.SelectCommand.CommandText = "sp_rel_agenda_atividade_geftb005";
                da.SelectCommand.Parameters.AddWithValue("@dt_agenda", DtAgenda);
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
        /// Atualiza os dados de presença e informações de agenda de um associado.
        /// </summary>
        /// <param name="dtagenda">Data da agenda.</param>
        /// <param name="sigla">Sigla da atividade.</param>
        /// <param name="idassociado">Id do associado.</param>
        /// <param name="presenca">Presença do associado.</param>
        /// <param name="hrent">Hora de entrada.</param>
        /// <param name="vestuario">Vestuário utilizado.</param>
        /// <param name="justificativa">Justificativa de ausência/presença.</param>
        /// <param name="dtgravacao">Data de gravação da alteração.</param>
        /// <returns>DataTable preenchido com os dados atualizados.</returns>
        public DataTable Update(string dtagenda, string sigla, int idassociado, string presenca, string hrent, string vestuario, string justificativa, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_atualizar_geftb005";
                da.SelectCommand.Parameters.AddWithValue("@dt_agenda", dtagenda);
                da.SelectCommand.Parameters.AddWithValue("@sigla", sigla);
                da.SelectCommand.Parameters.AddWithValue("@id_associado", idassociado);
                da.SelectCommand.Parameters.AddWithValue("@presenca", presenca);
                da.SelectCommand.Parameters.AddWithValue("@hr_entrada", hrent);
                da.SelectCommand.Parameters.AddWithValue("@vestuario", vestuario);
                da.SelectCommand.Parameters.AddWithValue("@justificativa", justificativa);
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
        /// Insere um novo registro de agenda.
        /// </summary>
        /// <param name="numsemana">Número da semana.</param>
        /// <param name="nomediasemana">Nome do dia da semana.</param>
        /// <param name="DtAgenda">Data da agenda.</param>
        /// <param name="dtgravacao">Data de gravação da inclusão.</param>
        /// <returns>DataTable preenchido com os dados inseridos.</returns>
        public DataTable Insert(int numsemana, string nomediasemana, string DtAgenda,  string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_inserir_geftb005";
                da.SelectCommand.Parameters.AddWithValue("@numsemana", numsemana);
                da.SelectCommand.Parameters.AddWithValue("@nomediasemana", nomediasemana);
                da.SelectCommand.Parameters.AddWithValue("@dt_agenda", DtAgenda);
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
        /// Insere um novo associado na agenda de uma atividade.
        /// </summary>
        /// <param name="dtAgenda">Data da agenda.</param>
        /// <param name="id_associado">Id do associado.</param>
        /// <param name="id_atividade">Id da atividade.</param>
        /// <param name="dtgravacao">Data de gravação da inclusão.</param>
        /// <returns>DataTable preenchido com os dados inseridos.</returns>
        public DataTable InsertAssociadoAgenda(string dtAgenda, int id_associado, int id_atividade, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_inserir_assagenda_geftb005";
                da.SelectCommand.Parameters.AddWithValue("@dt_agenda", dtAgenda);
                da.SelectCommand.Parameters.AddWithValue("@id_associado", id_associado);
                da.SelectCommand.Parameters.AddWithValue("@id_atividade", id_atividade);
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
