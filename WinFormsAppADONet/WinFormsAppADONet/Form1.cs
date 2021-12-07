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

            button2_Click(null, null);

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Programador programador = new Programador();
            programador.id = int.Parse(txbIdD.Text);

            programador = programador.consultaProgramador(programador.id);

            if (programador == null)
            {
                MessageBox.Show("Erro ao excluir: O programador não foi encontrado (404)!");
                return;
            }
            
            bool retorno = programador.excluirProgramador();

            if (retorno == true)
            {
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao executar a exlusão!");
            }

            button2_Click(null, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Programador programador = new Programador();
            programador.id = int.Parse(txbIdA.Text);
            programador.nome = txbNomeA.Text;
            programador.linguagem = txbLingA.Text;
            programador.banco = txbBdA.Text;

            bool retorno = programador.atualizarProgramador();

            if (retorno)
            {
                MessageBox.Show("Alterado com sucesso!");
                txbIdA.Text = "";
                txbNomeA.Text = "";
                txbLingA.Text = "";
                txbBdA.Text = "";
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }

            button2_Click(null, null);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
