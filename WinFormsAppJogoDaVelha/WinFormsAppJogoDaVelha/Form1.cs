using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppJogoDaVelha
{
    public partial class Form1 : Form
    {
        int count = 0;
        bool vezX = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComecaX_Click(object sender, EventArgs e)
        {
            vezX = true;

            lblVez.Text = "X";

            botoesEnable();

            btnComecaX.Enabled = false;
            btnComecaO.Enabled = false;

        }

        private void btnComecaO_Click(object sender, EventArgs e)
        {

            vezX = true;

            lblVez.Text = "O";

            botoesEnable();

            btnComecaX.Enabled = false;
            btnComecaO.Enabled = false;

        }

        private void botoesEnable()
        {
            btnC1L1.Enabled = true;
            btnC2L1.Enabled = true;
            btnC3L1.Enabled = true;
            btnC1L2.Enabled = true;
            btnC2L2.Enabled = true;
            btnC3L2.Enabled = true;
            btnC1L3.Enabled = true;
            btnC2L3.Enabled = true;
            btnC3L3.Enabled = true;
        }

        private void botoesEnableF()
        {
            btnC1L1.Enabled = false;
            btnC2L1.Enabled = false;
            btnC3L1.Enabled = false;
            btnC1L2.Enabled = false;
            btnC2L2.Enabled = false;
            btnC3L2.Enabled = false;
            btnC1L3.Enabled = false;
            btnC2L3.Enabled = false;
            btnC3L3.Enabled = false;
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            count = 0;
            btnC1L1.Enabled = false;
            btnC2L1.Enabled = false;
            btnC3L1.Enabled = false;
            btnC1L2.Enabled = false;
            btnC2L2.Enabled = false;
            btnC3L2.Enabled = false;
            btnC1L3.Enabled = false;
            btnC2L3.Enabled = false;
            btnC3L3.Enabled = false;

            btnC1L1.Text = "";
            btnC2L1.Text = "";
            btnC3L1.Text = "";
            btnC1L2.Text = "";
            btnC2L2.Text = "";
            btnC3L2.Text = "";
            btnC1L3.Text = "";
            btnC2L3.Text = "";
            btnC3L3.Text = "";

            lblVez.Text = " - ";
            lblVencedor.Text = " - ";

            btnComecaX.Enabled = true;
            btnComecaO.Enabled = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            count++;
            //MessageBox.Show("clique");
            Button btn = (Button)sender;
            btn.Text = lblVez.Text;

            if (vezX)
            {
                lblVez.Text = "O";
                btn.Enabled = false;
            }
            else
            {
                lblVez.Text = "X";
                btn.Enabled = false;
            }

            vezX = !vezX;

            if (!verificaVencedor())
            {

                if (count >= 9)
                {
                    btn.Text = lblVez.Text;
                    lblVez.Text = " - ";
                    btn.Enabled = false;
                    MessageBox.Show("O jogo acabou empatado!");
                }
            } 

        }

        private bool verificaVencedor()
        {
            if (btnC1L1.Text == btnC2L1.Text && btnC1L1.Text == btnC3L1.Text && btnC1L1.Text != "")
            {
                lblVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!");
                botoesEnableF();
                return true;
            }
            else if (btnC1L2.Text == btnC2L2.Text && btnC1L2.Text == btnC3L2.Text && btnC1L2.Text != "")
            {
                lblVencedor.Text = btnC1L2.Text;
                MessageBox.Show(btnC1L2.Text + " é o vencedor!");
                botoesEnableF();
                return true;
            }
            else if (btnC1L3.Text == btnC2L3.Text && btnC1L3.Text == btnC3L3.Text && btnC1L3.Text != "")
            {
                lblVencedor.Text = btnC1L3.Text;
                MessageBox.Show(btnC1L3.Text + " é o vencedor!");
                botoesEnableF();
                return true;
            }
            else if (btnC1L1.Text == btnC1L2.Text && btnC1L1.Text == btnC1L3.Text && btnC1L1.Text != "")//
            {
                lblVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!");
                botoesEnableF();
                return true;
            }
            else if (btnC2L1.Text == btnC2L2.Text && btnC2L1.Text == btnC2L3.Text && btnC2L1.Text != "")
            {
                lblVencedor.Text = btnC2L1.Text;
                MessageBox.Show(btnC2L1.Text + " é o vencedor!");
                botoesEnableF();
                return true;
            }
            else if (btnC3L1.Text == btnC3L2.Text && btnC3L1.Text == btnC3L3.Text && btnC3L1.Text != "")
            {
                lblVencedor.Text = btnC3L1.Text;
                MessageBox.Show(btnC3L1.Text + " é o vencedor!");
                botoesEnableF();
                return true;
            }

            else if (btnC1L1.Text == btnC2L2.Text && btnC1L1.Text == btnC3L3.Text && btnC1L1.Text != "")
            {
                lblVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!");
                botoesEnableF();
                return true;
            }

            else if (btnC3L1.Text == btnC2L2.Text && btnC3L1.Text == btnC1L3.Text && btnC3L1.Text != "")
            {
                lblVencedor.Text = btnC3L1.Text;
                MessageBox.Show(btnC3L1.Text + " é o vencedor!");
                botoesEnableF();
                return true;
            }

            return false;

        }
    }
}
