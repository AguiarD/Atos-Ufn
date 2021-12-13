using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDesafio
{
    class Pessoa
    {
        public string nome { get; set; }
        public string tel { get; set; }
        public string cidade { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }

        /*public Pessoa(string nome, string tel, string cidade, string rg, string cpf)
        {
            this.nome = nome;
            this.tel = tel;
            this.cidade = cidade;
            this.rg = rg;
            this.cpf = cpf;
        }*/

        public bool gravarPessoa()
        {
            Bd banco = new Bd();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction(); //Tem que ter o transaction para ter o rollback
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text; //dizer que o comando é do tipo texto

            //command.CommandText = "insert into Programadores values ('" + nome + "', '" + linguagem + "', '" + this.banco + "');"; //Modo errado - sql injection
            command.CommandText = "insert into Pessoas values (@nome, @telefone, @cidade, @rg, @cpf);";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@telefone", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@cidade", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@rg", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = tel;
            command.Parameters[2].Value = cidade;
            command.Parameters[3].Value = rg;
            command.Parameters[4].Value = cpf;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                Console.WriteLine("Try");
                return true;
            }
            catch (Exception ex)
            {

                tran.Rollback();
                Console.WriteLine("Cath");
                return false;
            }
            finally
            {
                Console.WriteLine("Finally");
                banco.fecharConexao();
            }





            //return true;
        }


        public void gravarPessoa2 (string nome, string tel, string cidade, string rg, string cpf)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.lerArquivo();
            while (arquivo != null)
            {

            }
            Bd banco = new Bd();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction(); //Tem que ter o transaction para ter o rollback
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text; //dizer que o comando é do tipo texto

            command.CommandText = "insert into Pessoas values (@nome, @telefone, @cidade, @rg, @cpf);";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@telefone", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@cidade", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@rg", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = tel;
            command.Parameters[2].Value = cidade;
            command.Parameters[3].Value = rg;
            command.Parameters[4].Value = cpf;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                Console.WriteLine("Try");
                //return true;
            }
            catch (Exception ex)
            {

                tran.Rollback();
                Console.WriteLine("Cath");
                //return false;
            }
            finally
            {
                Console.WriteLine("Finally");
                banco.fecharConexao();
            }
        }

    }
}
