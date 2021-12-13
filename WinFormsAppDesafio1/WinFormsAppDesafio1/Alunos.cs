using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDesafio1
{
    class Alunos
    {

        public string matricula { get; set; }
        public string codigo_curso { get; set; }
        public string nome_curso { get; set; }

        public bool importarArqAluno()
        {
            Bd banco = new Bd();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction(); //Tem que ter o transaction para ter o rollback
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text; //dizer que o comando é do tipo texo

            //command.CommandText = "insert into Programadores values ('" + nome + "', '" + linguagem + "', '" + this.banco + "');"; //Modo errado - sql injection
            command.CommandText = "insert into Alunos values (@matricula, @codigoCurso, @nomeCurso);";
            command.Parameters.Add("@matricula", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@codigoCurso", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@nomeCurso", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = matricula;
            command.Parameters[1].Value = codigo_curso;
            command.Parameters[2].Value = nome_curso;


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

        public int contarAlunos()
        {
            Bd banco = new Bd();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "select count(*) from ALUNOS;";

            //command.Parameters.Add("@codigo_curso", System.Data.SqlDbType.VarChar);
            //command.Parameters[0].Value = "cod_curso";

            //int contador = (int)command.Parameters[0];


            try
            {
                int contador = (int)command.ExecuteScalar();
                return contador;
            }
            catch (Exception ex)
            {

                tran.Rollback();
                return 0;
            }
            finally
            {
                banco.fecharConexao();
            }
        }
    }
}
