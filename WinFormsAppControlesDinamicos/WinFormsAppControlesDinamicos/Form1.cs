using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppControlesDinamicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.Text = "Clique";
            btn.Width = 200;
            btn.Click += Btn_Click;

            panel1.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click de um componente dinamico!");
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //txbTeste.Text = btnTeste.Text;
            Button btnT = new Button();
            btnT.Text = txbTeste.Text;
            btnT.Location = new Point(int.Parse(txbX.Text), int.Parse(txbY.Text));
            btnT.Size = new System.Drawing.Size(60, 60);
            this.Controls.Add(btnT);
        }
    }
}
