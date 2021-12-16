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
            if (ViewState["btnDinamico"] != null)
            {
                if ((bool)ViewState["btnDinamico"] == true)
                {
                    Button1_Click(null, null);
                }
            }
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

            btn.Click += Btn_Click;

            PlaceHolder1.Controls.Add(btn);
            ViewState["btnDinamico"] = true;
            //minhaDIV.Controls.Add(btn);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            label.Text = textBox.Text;
        }

        protected void btnAlert_Click(object sender, EventArgs e)
        {
            Literal1.Text = "<script>alert('" + textBox.Text + "');</script>";
        }

        [WebMethod]
        public static string alerta1()
        {
            return "webservice 1";
        }


        [WebMethod]

        public static string alerta2(string valor)
        {
            return (int.Parse(valor) * 2).ToString();
        }

    }
}