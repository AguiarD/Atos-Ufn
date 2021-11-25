using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAula01AtosUFN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O nome é " + txbNome.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vl1, vl2;
            vl1 = int.Parse(txbNum1.Text);
            vl2 = int.Parse(txbNum2.Text);

            int resultado = vl1 + vl2;

            //labelExibirResultado.Text = resultado;

            MessageBox.Show("Soma é: " + resultado);
            txbNum1.Text = "";
            txbNum2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vl1, vl2;
            vl1 = int.Parse(txbNumero1.Text);
            vl2 = int.Parse(txbNumero2.Text);

            int resultado = vl1 + vl2;

            if (resultado % 2 == 0)
            {
                btnSomar.BackColor =  Color.Green;
                //MessageBox.Show("Soma é: " + resultado + " Par");
                txbNumero1.Text = "";
                txbNumero2.Text = "";
            }
            else
            {
                btnSomar.BackColor = Color.Red;
            }

            //MessageBox.Show("Soma é: " + resultado);
        }

        private void btnVerificarIdade_Click(object sender, EventArgs e)
        {
            int idade;

            idade = int.Parse(txbIdadeNome.Text);

            if (idade >= 18)
            {
                labelSim.Font = new Font(labelSim.Font, FontStyle.Bold);
                labelNao.Font = new Font(labelNao.Font, FontStyle.Regular);
            }
            else
            {
                labelNao.Font = new Font(labelNao.Font, FontStyle.Bold);
                labelSim.Font = new Font(labelSim.Font, FontStyle.Regular);
            }

        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            btnMover.Location = new Point(btnMover.Location.X - 5, btnMover.Location.Y);
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            btnMover.Location = new Point(btnMover.Location.X + 5, btnMover.Location.Y);
        }
    }
}
