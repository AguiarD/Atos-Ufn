using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDesafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbPessoa_TextChanged(object sender, EventArgs e)
        {
            Arquivo a = new Arquivo();

            a.lerArquivo();
            txbNome.Text = a.ToString();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            bool retorno = pessoa.gravarPessoa();

            if (pessoa.gravarPessoa())
            {
                MessageBox.Show("Gravado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro!");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            Bd banco = new Bd();

            string sql = "select * from Pessoas";

            DataTable dt = new DataTable();

            dt = banco.executarConsultaGenerica(sql);

            dataG1.DataSource = dt;
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            Bd banco = new Bd();

            string sql = "select * from Alunos";

            DataTable dt = new DataTable();

            dt = banco.executarConsultaGenerica(sql);

            dataG2.DataSource = dt;
        }
    }
}
