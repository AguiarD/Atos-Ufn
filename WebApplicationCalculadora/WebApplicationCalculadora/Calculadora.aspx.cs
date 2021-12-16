﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdoSomar.Checked)
            {
                int resultado = int.Parse(txbVl1.Text) + int.Parse(txbVl2.Text);
                lblResultado.Text = resultado.ToString();
                txbVl1.Text = null;
                txbVl2.Text = null;
            }
            else if (rdoSubtrair.Checked)
            {
                int resultado = int.Parse(txbVl1.Text) - int.Parse(txbVl2.Text);
                lblResultado.Text = resultado.ToString();
                txbVl1.Text = null;
                txbVl2.Text = null;
            }
            else
            {
                lblResultado.Text = "Escolher a operação!";
            }
        }
    }
}