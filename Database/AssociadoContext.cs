using NovoGEF.Models;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NovoGEF.Database
{
    /// <summary>
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de associados (geftb002).
    /// </summary>
    public class AssociadoContext
    {
        private readonly string connectionString = Conn.StrConn;
        /// <summary>
        /// Busca associados conforme tipo, classificação e situação.
        /// </summary>
        /// <param name="tipo">Tipo do associado.</param>
        /// <param name="classificacao">Classificação do associado.</param>
        /// <param name="situacao">Situação do associado.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public string Search(string tipo, int classificacao, int situacao, DataTable dt)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(null, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "sp_buscar_geftb002";
                da.SelectCommand.Parameters.AddWithValue("@tipo", tipo);
                da.SelectCommand.Parameters.AddWithValue("@classificacao", classificacao);
                da.SelectCommand.Parameters.AddWithValue("@situacao", situacao);
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
        /// Busca associados pelo número de matrícula.
        /// </summary>
        /// <param name="tipo">Tipo do associado.</param>
        /// <param name="classificacao">Classificação do associado.</param>
        /// <param name="situacao">Situação do associado.</param>
        /// <param name="matricula">Número da matrícula.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public string SearchMatricula(string tipo, int classificacao, int situacao, string matricula, DataTable dt)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(null, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "sp_buscar_matricula_geftb002";
                da.SelectCommand.Parameters.AddWithValue("@tipo", tipo);
                da.SelectCommand.Parameters.AddWithValue("@classificacao", classificacao);
                da.SelectCommand.Parameters.AddWithValue("@situacao", situacao);
                da.SelectCommand.Parameters.AddWithValue("@matricula", matricula);
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
        /// Busca associados pelo nome.
        /// </summary>
        /// <param name="tipo">Tipo do associado.</param>
        /// <param name="classificacao">Classificação do associado.</param>
        /// <param name="situacao">Situação do associado.</param>
        /// <param name="nome">Nome do associado.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public string SearchNome(string tipo, int classificacao, int situacao, string nome, DataTable dt)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(null, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "sp_buscar_nome_geftb002";
                da.SelectCommand.Parameters.AddWithValue("@tipo", tipo);
                da.SelectCommand.Parameters.AddWithValue("@classificacao", classificacao);
                da.SelectCommand.Parameters.AddWithValue("@situacao", situacao);
                da.SelectCommand.Parameters.AddWithValue("@nome", nome);
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
        /// Busca associados pelo id e nome.
        /// </summary>
        /// <param name="tipo">Tipo do associado.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public string SearchIdNome(string tipo, DataTable dt)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(null, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "sp_buscar_idnome_geftb002";
                da.SelectCommand.Parameters.AddWithValue("@tipo", tipo);
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
        /// Atualiza os dados de um associado no banco de dados.
        /// </summary>
        /// <param name="associado">Objeto Associado a ser inserido.</param>
        /// <returns>DataTable preenchido com os dados do associado atualizado.</returns>
        public string Update(Associado associado)
        {
            var sql = "UPDATE [dbo].[geftb002_associado] SET " +
			          "dt_ini 				= 	@dt_ini, " +
			          "dt_fim 				= 	@dt_fim, " +
			          "nome 				= 	UPPER(@nome), " +
			          "dt_nascimento 		= 	@dt_nascimento, " +
			          "endereco 			=	UPPER(@endereco), " +
			          "bairro 				= 	UPPER(@bairro), " +
			          "cidade 				= 	UPPER(@cidade), " +
			          "cep 					= 	@cep, " +
			          "tel1 				= 	@tel1, " +
			          "tel2 				=	@tel2, " +
			          "cpf 					= 	@cpf, " +
			          "obs 					= 	UPPER(@obs), " +
			          "email 				= 	@email, " +
			          "parentesco 			= 	@parentesco, " +
			          "dt_gravacao 			= 	@dt_gravacao, " +
			          "geftb001_usuario_id_usuario 	=	@geftb001_usuario_id_usuario " +
	                  "WHERE id_associado = @id_associado";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@idassociado", associado.id_associado);
                        cmd.Parameters.AddWithValue("@nome", associado.Nome);
                        cmd.Parameters.AddWithValue("@dt_nascimento", associado.Dt_Nascimento);
                        cmd.Parameters.AddWithValue("@dt_ini", associado.Dt_Ini);
                        cmd.Parameters.AddWithValue("@dt_fim", associado.Dt_Fim);
                        cmd.Parameters.AddWithValue("@cpf", associado.Cpf);
                        cmd.Parameters.AddWithValue("@tel1", associado.Tel1);
                        cmd.Parameters.AddWithValue("@tel2", associado.Tel2);
                        cmd.Parameters.AddWithValue("@email", associado.Email);
                        cmd.Parameters.AddWithValue("@endereco", associado.Endereco);
                        cmd.Parameters.AddWithValue("@bairro", associado.Bairro);
                        cmd.Parameters.AddWithValue("@cidade", associado.Cidade);
                        cmd.Parameters.AddWithValue("@cep", associado.Cep);
                        cmd.Parameters.AddWithValue("@parentesco", associado.Parentesco);
                        cmd.Parameters.AddWithValue("@obs", associado.Obs);
                        cmd.Parameters.AddWithValue("@dt_gravacao", associado.Dt_Gravacao);
                        cmd.Parameters.AddWithValue("@geftb001_usuario_id_usuario", associado.Geftb001_Id_Usuario);
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
        /// Insere um novo associado no banco de dados utilizando um objeto Associado e o tipo ou dependente.
        /// </summary>
        /// <param name="associado">Objeto Associado a ser inserido.</param>
        /// <param name="titoudep">Tipo ou dependente.</param>
        /// <returns>String vazia em caso de sucesso ou mensagem de erro em caso de falha.</returns>
        public string Insert(Associado associado, int titoudep)
        {
            var sql = "";
            if (titoudep == 0)
            {
                sql = "INSERT INTO geftb002_associado(matricula, dt_ini, nome, dt_nascimento, endereco, bairro, cidade, cep, tel1, tel2, cpf, obs, email, parentesco, dt_gravacao, geftb001_usuario_id_usuario) " +
                          "VALUES(SUBSTRING(@matricula, 1, 1) + (SELECT MAX(SUBSTRING(MATRICULA, 2, 5)) + 1 FROM GEFTB002_ASSOCIADO WHERE SUBSTRING(MATRICULA, 1, 1) = SUBSTRING(@matricula, 1, 1)) + '00', " +
                          "@dt_ini, UPPER(@nome), @dt_nascimento,  UPPER(@endereco), UPPER(@bairro), UPPER(@cidade), @cep, @tel1, @tel2, @cpf, UPPER(@obs), @email, @parentesco,  @dt_gravacao, @geftb001_usuario_id_usuario)";
            }
            else
            {
                sql = "insert into geftb002_associado(matricula, dt_ini, nome, dt_nascimento, endereco, bairro, cidade, cep, tel1, tel2, cpf, obs, email, parentesco, dt_gravacao, geftb001_usuario_id_usuario) " +
                          "VALUES(SUBSTRING(@matricula, 1, 1) + @matricula + (SELECT MAX(SUBSTRING(MATRICULA, 7, 2)) + 1 FROM GEFTB002_ASSOCIADO WHERE SUBSTRING(MATRICULA, 1, 6) = SUBSTRING(@matricula, 1, 6)), " +
                          "@dt_ini, UPPER(@nome), @dt_nascimento, UPPER(@endereco), UPPER(@bairro), UPPER(@cidade), @cep, @tel1, @tel2, @cpf, UPPER(@obs), @email, @parentesco,  @dt_gravacao, @geftb001_usuario_id_usuario)";
            }
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@matricula", associado.Matricula);
                        cmd.Parameters.AddWithValue("@nome", associado.Nome);
                        cmd.Parameters.AddWithValue("@dt_nascimento", associado.Dt_Nascimento);
                        cmd.Parameters.AddWithValue("@dt_ini", associado.Dt_Ini);
                        cmd.Parameters.AddWithValue("@dt_fim", associado.Dt_Fim);
                        cmd.Parameters.AddWithValue("@cpf", associado.Cpf);
                        cmd.Parameters.AddWithValue("@tel1", associado.Tel1);
                        cmd.Parameters.AddWithValue("@tel2", associado.Tel2);
                        cmd.Parameters.AddWithValue("@email", associado.Email);
                        cmd.Parameters.AddWithValue("@endereco", associado.Endereco);
                        cmd.Parameters.AddWithValue("@bairro", associado.Bairro);
                        cmd.Parameters.AddWithValue("@cidade", associado.Cidade);
                        cmd.Parameters.AddWithValue("@cep", associado.Cep);
                        cmd.Parameters.AddWithValue("@parentesco", associado.Parentesco);
                        cmd.Parameters.AddWithValue("@obs", associado.Obs);
                        cmd.Parameters.AddWithValue("@dt_gravacao", associado.Dt_Gravacao);
                        cmd.Parameters.AddWithValue("@geftb001_usuario_id_usuario", associado.Geftb001_Id_Usuario);
                        cmd.ExecuteNonQuery();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return "Houve uma falha no banco de dados ao incluir os dados do associado. Por favor entre em contato com o administrador do sistema. " + ex.Message + ex.StackTrace;
            }
        }
    }
}
