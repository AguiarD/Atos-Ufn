using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Animal a = new Animal();
            a.sexo = "M";
            a.raca = "Leaozão";
            a.nome = "Rei LEão";
            Console.WriteLine(a.nome);
            a.emitirSom();
            MessageBox.Show(a.nome);
            label1.Text = "Animal";*/

            Arvore arv = new Arvore();
            arv.id = 100;
            arv.nome = "Cinamomo";
            arv.viver();
            arv.morrer();
            MessageBox.Show(arv.nome);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leao l = new Leao();
            l.nome = "Leaozinho";
            Console.WriteLine(l.nome);
            l.emitirSom();
            MessageBox.Show(l.nome);
            label2.Text = "Leao";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Figueira fig = new Figueira();
            fig.viver();
            fig.morrer();
            
        }
    }
}
