using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppCriptografiaELogin
{
    class Usuarios
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string tp_senha { get; set; }

        public bool gravarUsuario()
        {
            Bd banco = new Bd();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction(); //Tem que ter o transaction para ter o rollback
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text; //dizer que o comando é do tipo texo

            //command.CommandText = "insert into Programadores values ('" + nome + "', '" + linguagem + "', '" + this.banco + "');"; //Modo errado - sql injection
            command.CommandText = "insert into USUARIOS values (@nome, @email, @senha, @tipo);";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@senha", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = email;
            command.Parameters[2].Value = senha;
            command.Parameters[3].Value = tp_senha;

            //lembrar de validar se o email que estamos tentando inserir, ja existe no banco de dados - podemos usar o ExecuteScalar() para retornar um registro
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





            //return true;
        }
    }
}
