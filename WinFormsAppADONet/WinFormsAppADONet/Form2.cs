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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from programadores";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Programador programador = new Programador();
            programador.nome = txbNomeInc.Text;
            programador.linguagem = txbLingInc.Text;
            programador.banco = txbBancoInc.Text;

            bool retorno = programador.gravarProgramador();
            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
                txbIdAlt.Text = "";
                txbNomeAlt.Text = "";
                txbLingAlt.Text = "";
                txbBancoAlt.Text = "";
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }

            btnListar_Click(null, null);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Programador programador = new Programador();
            programador.consultaProgramador(int.Parse(txbConsultaId.Text));
            MessageBox.Show(programador.nome);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                try
                {
                    Programador programador = new Programador();
                    int idProgramador = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    programador = programador.consultaProgramador(idProgramador);
                    txbIdAlt.Text = programador.id.ToString();
                    txbNomeAlt.Text = programador.nome;
                    txbLingAlt.Text = programador.linguagem;
                    txbBancoAlt.Text = programador.banco;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            btnListar_Click(null, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Programador programador = new Programador();
            programador.id = int.Parse(txbIdAlt.Text);
            programador.nome = txbNomeAlt.Text;
            programador.linguagem = txbLingAlt.Text;
            programador.banco = txbBancoAlt.Text;

            bool retorno = programador.atualizarProgramador();

            if (retorno)
            {
                MessageBox.Show("Alterado com sucesso!");
                txbIdAlt.Text = "";
                txbNomeAlt.Text = "";
                txbLingAlt.Text = "";
                txbBancoAlt.Text = "";
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }

            btnListar_Click(null, null);
        }
    }
}
