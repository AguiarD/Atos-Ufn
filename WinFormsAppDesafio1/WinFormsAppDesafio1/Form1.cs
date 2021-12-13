using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDesafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            Bd banco = new Bd();

            string sql = "select * from Pessoas";

            DataTable dt = new DataTable();

            dt = banco.executarConsultaGenerica(sql);

            dataGListar.DataSource = dt;
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            Bd banco = new Bd();

            string sql = "select * from Alunos";

            DataTable dt = new DataTable();

            dt = banco.executarConsultaGenerica(sql);

            dataGListar.DataSource = dt;
        }

        StreamReader sr;
        public int contP = 0, contA = 0;
        private void btnImportar_Click(object sender, EventArgs e)
        {

            //string linha;
            string[] pessoas;
            sr = new StreamReader("C:\\Users\\Cliente\\Pictures\\teste\\desafio1.txt");
            while (sr.Peek() > 0)
            {
            string linha = sr.ReadLine();
                //linha = sr.ReadLine();

                try
                {

                    pessoas = linha.Split('-');

                    if (pessoas[0] == "Z")
                    {
                        //Pessoa a = new Pessoa();
                        string nome = pessoas[1];
                        string telefone = pessoas[2];
                        string cidade = pessoas[3];
                        string rg = pessoas[4];
                        string cpf = pessoas[5];
                        /*Console.WriteLine(pessoas[0]);
                        Console.WriteLine(pessoas[1]);
                        Console.WriteLine(pessoas[2]);
                        Console.WriteLine(pessoas[3]);
                        Console.WriteLine(pessoas[4]);
                        Console.WriteLine(pessoas[5]);*/
                        //a.gravarPessoa();
                        contP++;

                        Pessoas pessoa = new Pessoas();
                        pessoa.nome = nome;
                        pessoa.tel = telefone;
                        pessoa.cidade = cidade;
                        pessoa.rg = rg;
                        pessoa.cpf = cpf;

                        pessoa.importarArquivo();
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
    }
}
