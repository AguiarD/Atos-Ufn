using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppRemedios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*DateTime data_hora;
            data_hora = DateTime.Now;




            lblHora.Text = data_hora.ToLongTimeString();

            label1.Text = data_hora.ToLongTimeString();*/

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        //    DateTime data_hora;
        //    data_hora = DateTime.Now;

        //    lblHora.Text = data_hora.ToLongTimeString();

        ////    timer2.Enabled = true;
        //    lblHora.Text = data_hora.ToLongTimeString();

            Bd bd = new Bd();

            string sql = "select * from REMEDIOS";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridViewListar.DataSource = dt;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
   

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Timer timer = new Timer();
            //timer.Interval = 1000;
            //timer.Tick +=  new EventHandler(timer_tick01);    
            //timer.Start();


            timer1.Interval = 1000;
            timer1.Start();


        }

        private void timer_tick01(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime data_hora;
            data_hora = DateTime.Now;


            label1.Text = data_hora.ToLongTimeString();
            //Application.DoEvents();

            Bd bd = new Bd();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from REMEDIOS", cn);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string [] t = reader.GetString(2).Split(':');
                    int h = int.Parse(t[0]);
                    int m = int.Parse(t[1]);
                    int s = int.Parse(t[2]);

                    //string time = reader.GetString(2);

                    if(h == data_hora.Hour && m == data_hora.Minute && s == data_hora.Second)
                    {
                        MessageBox.Show("Hora de tomar o Remedio " + reader.GetString(1));
                        //break;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                return;
            }
            finally
            {
                bd.fecharConexao();
            }

        }
    }
}
