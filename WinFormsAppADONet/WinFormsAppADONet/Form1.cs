using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppADONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Banco banco = new Banco();
            //banco.abrirConexao();

            Programador programador = new Programador();
            programador.nome = txbNome.Text;
            programador.linguagem = txbLinguagem.Text;
            programador.banco = txbBanco.Text;

            bool retorno = programador.gravarProgramador();
            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }

        }

        private void btnConsultarId_Click(object sender, EventArgs e)
        {
            Programador programador = new Programador();
            programador.consultaProgramador(int.Parse(textBox1.Text));
            MessageBox.Show(programador.nome);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from programadores";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }
    }
}
