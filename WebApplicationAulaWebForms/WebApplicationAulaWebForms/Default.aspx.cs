using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationAulaWebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //lblNome.Text = txbNome.Text;

            Bd bd = new Bd();

            string sql = "select * from REMEDIOS";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            GridView1.DataSource = dt;
            GridView1.DataBind();


            //***********

            Button btn = new Button();
            btn.Text = "botão dinamico";

            //btn.Click += Btn_Click;

            minhaDIV.Controls.Add(btn);

        }

        protected void btnAlert_Click(object sender, EventArgs e)
        {
            Literal1.Text = "<script>alert('" + txbNome.Text + "');</script>";
        }

        [WebMethod]
        public static string alerta1()
        {
            return "webservice 1";
        }



        /*private void Btn_Click(object sender, EventArgs e)
        {
            lblNome.Text = "Teste";
        }*/
    }
}