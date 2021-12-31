using GestaoFinanceira.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira.Repository
{
    public class LancamentoRepository : Conexao
    {
        // Método: CREATE
        public bool AdicionarLancamento(Lancamento lanc)
        {
            try
            {
                AbrirConexao();

                //Aqui estou chamando a procedure:
                /*Cmd = new SqlCommand("AdicionarNovoFuncionario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Nome", lanc.Nome);
                Cmd.Parameters.AddWithValue("@Sobrenome", lanc.Sobrenome);
                Cmd.Parameters.AddWithValue("Cidade", lanc.Cidade);
                Cmd.Parameters.AddWithValue("@Endereco", lanc.Endereco);
                Cmd.Parameters.AddWithValue("@Email", lanc.Email);*/

                Cmd = new SqlCommand("insert into Lancamentos values ( @tipo, @valor, @grupo, @conta, @obs, @dt_previsao, @dt_baixa, @inativo)", Con);
                Cmd.Parameters.AddWithValue("@tipo", lanc.tipo);
                Cmd.Parameters.AddWithValue("@valor", lanc.valor);
                Cmd.Parameters.AddWithValue("@grupo", lanc.grupo);
                Cmd.Parameters.AddWithValue("@conta", lanc.conta);
                Cmd.Parameters.AddWithValue("@obs", lanc.obs);
                Cmd.Parameters.AddWithValue("@dt_previsao", lanc.dt_previsao);
                Cmd.Parameters.AddWithValue("@dt_baixa", lanc.dt_baixa);
                Cmd.Parameters.AddWithValue("@inativo", lanc.inativo);



                int i = Cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Adicionar Novo Lançamento: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método: READ 
        public List<Lancamento> SelecionarLancamentos()
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Lancamentos", Con);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Aqui irá ler os registros obtidos através do SqlDataReader
                Dr = Cmd.ExecuteReader();

                // Criando uma lista vazia
                var lista = new List<Lancamento>();

                while (Dr.Read())
                {
                    var lanc = new Lancamento
                    {
                        id = Convert.ToInt32(Dr["Id"]),
                        tipo = Convert.ToString(Dr["Tipo"]),
                        valor = Convert.ToDouble(Dr["Valor"]),
                        grupo = Convert.ToString(Dr["Grupo"]),
                        conta = Convert.ToString(Dr["Conta"]),
                        obs = Convert.ToString(Dr["Observacao"]),
                        dt_previsao = Convert.ToDateTime(Dr["Previsao"]),
                        dt_baixa = Convert.ToDateTime(Dr["Baixa"]),
                        inativo = Convert.ToDateTime(Dr["Inativo"])
                    };

                    lista.Add(lanc);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao selecionar o lancamento: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método: Update
        public bool AtualizarLancamento(Lancamento lanc)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Lancamentos set tipo = @tipo, valor = @valor, grupo = @grupo, conta = @conta, obs = @obs, dt_previsao = @dt_previsao, dt_baixa = @dt_baixa, inativo = @inativo where id = @idLancamento", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                /*Cmd.Parameters.AddWithValue("@IdFuncionario", func.IdFuncionario);
                Cmd.Parameters.AddWithValue("@Nome", func.Nome);
                Cmd.Parameters.AddWithValue("@Sobrenome", func.Sobrenome);
                Cmd.Parameters.AddWithValue("@Endereco", func.Endereco);
                Cmd.Parameters.AddWithValue("@Cidade", func.Cidade);
                Cmd.Parameters.AddWithValue("@Email", func.Email);*/

                Cmd.Parameters.AddWithValue("@idLancamento", lanc.id);
                Cmd.Parameters.AddWithValue("@tipo", lanc.tipo);
                Cmd.Parameters.AddWithValue("@valor", lanc.valor);
                Cmd.Parameters.AddWithValue("@grupo", lanc.grupo);
                Cmd.Parameters.AddWithValue("@conta", lanc.conta);
                Cmd.Parameters.AddWithValue("@obs", lanc.obs);
                Cmd.Parameters.AddWithValue("@dt_previsao", lanc.dt_previsao);
                Cmd.Parameters.AddWithValue("@dt_baixa", lanc.dt_baixa);
                Cmd.Parameters.AddWithValue("@inativo", lanc.inativo);

                int i = Cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Atualizar Lancamento: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método: Delete
        public bool ExcluirLancamento(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Lancamentos where id = @idLancamento", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@idLancamento", Con);

                int i = Cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir Lancamento: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
