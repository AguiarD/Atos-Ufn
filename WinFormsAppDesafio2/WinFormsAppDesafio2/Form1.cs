using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDesafio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data_hora;
            data_hora = DateTime.Now;

            lblHora.Text = data_hora.ToLongTimeString();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Bd bd = new Bd();

            string sql = "select * from REMEDIOS";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridViewListar.DataSource = dt;
        }
    }
}
