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
using static System.Net.Mime.MediaTypeNames;
using NovoGEF.Models;

namespace NovoGEF.Database
{
    /// <summary>
    /// Classe responsável pelas operações de acesso e manipulação de dados da tabela de associados (geftb002).
    /// </summary>
    public class Geftb002
    {
        /// <summary>
        /// Busca associados conforme tipo, classificação e situação.
        /// </summary>
        /// <param name="tipo">Tipo do associado.</param>
        /// <param name="classificacao">Classificação do associado.</param>
        /// <param name="situacao">Situação do associado.</param>
        /// <param name="dt">DataTable para preenchimento dos dados.</param>
        /// <returns>DataTable preenchido com os dados encontrados.</returns>
        public DataTable Search(string tipo, int classificacao, int situacao, DataTable dt)
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
        public DataTable SearchMatricula(string tipo, int classificacao, int situacao, string matricula, DataTable dt)
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
        public DataTable SearchNome(string tipo, int classificacao, int situacao, string nome, DataTable dt)
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
        public DataTable SearchIdNome(string tipo, DataTable dt)
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
        /// <param name="idassociado">Id do associado.</param>
        /// <param name="nome">Nome do associado.</param>
        /// <param name="dtnasc">Data de nascimento.</param>
        /// <param name="dtini">Data de início.</param>
        /// <param name="dtfim">Data de fim.</param>
        /// <param name="cpf">CPF do associado.</param>
        /// <param name="tel1">Telefone 1.</param>
        /// <param name="tel2">Telefone 2.</param>
        /// <param name="email">E-mail do associado.</param>
        /// <param name="end">Endereço.</param>
        /// <param name="bairro">Bairro.</param>
        /// <param name="cidade">Cidade.</param>
        /// <param name="cep">CEP.</param>
        /// <param name="parentesco">Parentesco.</param>
        /// <param name="obs">Observações.</param>
        /// <param name="id_usuario">Chave do usuario.</param>
        /// <param name="dtgravacao">Data de gravação.</param>
        /// <returns>DataTable preenchido com os dados do associado atualizado.</returns>
        public DataTable Update(int idassociado, string nome, string dtnasc, string dtini, string dtfim, string cpf, string tel1, string tel2, string email, string end, string bairro, string cidade, string cep, string parentesco, string obs, int id_usuario, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_atualizar_geftb002";
                da.SelectCommand.Parameters.AddWithValue("@id_associado", idassociado);
                da.SelectCommand.Parameters.AddWithValue("@nome", nome);
                da.SelectCommand.Parameters.AddWithValue("@dt_nascimento", dtnasc);
                da.SelectCommand.Parameters.AddWithValue("@dt_ini", dtini);
                da.SelectCommand.Parameters.AddWithValue("@dt_fim", dtfim);
                da.SelectCommand.Parameters.AddWithValue("@cpf", cpf);
                da.SelectCommand.Parameters.AddWithValue("@tel1", tel1);
                da.SelectCommand.Parameters.AddWithValue("@tel2", tel2);
                da.SelectCommand.Parameters.AddWithValue("@email", email);
                da.SelectCommand.Parameters.AddWithValue("@endereco", end);
                da.SelectCommand.Parameters.AddWithValue("@bairro", bairro);
                da.SelectCommand.Parameters.AddWithValue("@cidade", cidade);
                da.SelectCommand.Parameters.AddWithValue("@cep", cep);
                da.SelectCommand.Parameters.AddWithValue("@parentesco", parentesco);
                da.SelectCommand.Parameters.AddWithValue("@obs", obs);
                da.SelectCommand.Parameters.AddWithValue("@dt_gravacao", dtgravacao);
                da.SelectCommand.Parameters.AddWithValue("@geftb001_usuario_id_usuario", id_usuario);
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
        /// Insere um novo associado no banco de dados.
        /// </summary>
        /// <param name="titoudep">Tipo ou dependente.</param>
        /// <param name="matricula">Matrícula do associado.</param>
        /// <param name="nome">Nome do associado.</param>
        /// <param name="dtnasc">Data de nascimento.</param>
        /// <param name="dtini">Data de início.</param>
        /// <param name="dtfim">Data de fim.</param>
        /// <param name="cpf">CPF do associado.</param>
        /// <param name="tel1">Telefone 1.</param>
        /// <param name="tel2">Telefone 2.</param>
        /// <param name="email">E-mail do associado.</param>
        /// <param name="end">Endereço.</param>
        /// <param name="bairro">Bairro.</param>
        /// <param name="cidade">Cidade.</param>
        /// <param name="cep">CEP.</param>
        /// <param name="parentesco">Parentesco.</param>
        /// <param name="obs">Observações.</param>
        /// <param name="id_usuario">Chave do usuario.</param>
        /// <param name="dtgravacao">Data de gravação.</param>
        /// <returns>DataTable preenchido com os dados do associado inserido.</returns>
        public DataTable Insert(int titoudep, string matricula, string nome, string dtnasc, string dtini, string dtfim, string cpf, string tel1, string tel2, string email, string end, string bairro, string cidade, string cep, string parentesco, string obs,  int id_usuario, string dtgravacao)
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
                da.SelectCommand.CommandText = "sp_inserir_geftb002";
                da.SelectCommand.Parameters.AddWithValue("@titoudep", titoudep);
                da.SelectCommand.Parameters.AddWithValue("@matricula", matricula);
                da.SelectCommand.Parameters.AddWithValue("@nome", nome);
                da.SelectCommand.Parameters.AddWithValue("@dt_nascimento", dtnasc);
                da.SelectCommand.Parameters.AddWithValue("@dt_ini", dtini);
                da.SelectCommand.Parameters.AddWithValue("@dt_ini", dtfim);
                da.SelectCommand.Parameters.AddWithValue("@cpf", cpf);
                da.SelectCommand.Parameters.AddWithValue("@tel1", tel1);
                da.SelectCommand.Parameters.AddWithValue("@tel2", tel2);
                da.SelectCommand.Parameters.AddWithValue("@email", email);
                da.SelectCommand.Parameters.AddWithValue("@endereco", end);
                da.SelectCommand.Parameters.AddWithValue("@bairro", bairro);
                da.SelectCommand.Parameters.AddWithValue("@cidade", cidade);
                da.SelectCommand.Parameters.AddWithValue("@cep", cep);
                da.SelectCommand.Parameters.AddWithValue("@parentesco", parentesco);
                da.SelectCommand.Parameters.AddWithValue("@obs", obs);
                da.SelectCommand.Parameters.AddWithValue("@dt_gravacao", dtgravacao);
                da.SelectCommand.Parameters.AddWithValue("@geftb001_usuario_id_usuario", id_usuario);
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
