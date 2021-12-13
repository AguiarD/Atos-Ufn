using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDesafio1
{
    class Pessoas
    {
        public string nome { get; set; }
        public string tel { get; set; }
        public string cidade { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }



        StreamReader sr;
        public int contP = 0, contA = 0;
        //Pessoa a = new Pessoa();


        public void lerArquivo()
        {
            string linha;
            string[] pessoas;
            sr = new StreamReader("C:\\Users\\Cliente\\Pictures\\teste\\desafio1.txt");
            while (sr.Peek() > 0)
            {
                linha = sr.ReadLine();

                Console.WriteLine(linha);
                try
                {

                    pessoas = linha.Split('-');

                    if (pessoas[0] == "Z")
                    {
                        //Pessoa a = new Pessoa();
                        nome = pessoas[1];
                        tel = pessoas[2];
                        cidade = pessoas[3];
                        rg = pessoas[4];
                        cpf = pessoas[5];
                        /*Console.WriteLine(pessoas[0]);
                        Console.WriteLine(pessoas[1]);
                        Console.WriteLine(pessoas[2]);
                        Console.WriteLine(pessoas[3]);
                        Console.WriteLine(pessoas[4]);
                        Console.WriteLine(pessoas[5]);*/
                        //a.gravarPessoa();
                        contP++;
                    }
                    else if (pessoas[0] == "Y")
                    {


                        /*Console.WriteLine(pessoas[0]);
                        Console.WriteLine(pessoas[1]);
                        Console.WriteLine(pessoas[2]);
                        Console.WriteLine(pessoas[3]);*/
                    }
                    Console.WriteLine();
                    //}
                }
                catch (Exception ex)
                {

                    sr.Close();
                }
            }

        }

        public bool importarArquivo()
        {
            Bd banco = new Bd();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction(); //Tem que ter o transaction para ter o rollback
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text; //dizer que o comando é do tipo texo

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
