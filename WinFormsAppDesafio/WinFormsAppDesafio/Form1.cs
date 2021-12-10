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
        }
    }
}
