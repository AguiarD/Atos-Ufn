using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppADONet
{
    class Programador
    {
        public int id;
        public string nome;
        public string linguagem;
        public string banco;

        public bool gravarProgramador()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction(); //Tem que ter o transaction para ter o rollback
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text; //dizer que o comando é do tipo texo

            //command.CommandText = "insert into Programadores values ('" + nome + "', '" + linguagem + "', '" + this.banco + "');"; //Modo errado - sql injection
            command.CommandText = "insert into Programadores values (@nome, @linguagem, @banco);";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@linguagem", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@banco", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = linguagem;
            command.Parameters[2].Value = this.banco;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {

                tran.Rollback();
                return false;
            } 
            finally
            {
                banco.fecharConexao();
            }





            return true;
        }

        public bool excluirProgramador()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from Programadores where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {

                tran.Rollback();
                return false;
            } 
            finally
            {
                bd.fecharConexao();
            }

        }

        public bool atualizarProgramador()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update Programadores set nome = @nome, linguagem = @linguagem, banco = @banco where id = @id";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@linguagem", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@banco", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = linguagem;
            cmd.Parameters[2].Value = banco;
            cmd.Parameters[3].Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {

                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public Programador consultaProgramador(int id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from Programadores", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0); //GetInt por causa do ID, conforme a base de dados.
                        nome = reader.GetString(1); //GetString por causa do nome, conforme a base de dados.
                        linguagem = reader.GetString(2);  //GetString por causa da linguagem, conforme a base de dados.
                        banco = reader.GetString(3);  //GetString por causa do banco, conforme a base de dados.

                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
                
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
