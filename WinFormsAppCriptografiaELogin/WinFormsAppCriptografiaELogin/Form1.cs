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

namespace WinFormsAppCriptografiaELogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string key = "ChaveUsuario";
        private void btnGravar_Click(object sender, EventArgs e)
        {

            Simetrica simetrica = new Simetrica();
            //string key = "ChaveUsuario";
            string senha = txbSenha.Text;

            //criptografar
            string senhaCripto = simetrica.EncryptData(senha, key);
            
            Usuarios usuario = new Usuarios();
            usuario.nome = txbNome.Text;
            usuario.email = txbEmail.Text;
            usuario.senha = senhaCripto;
            usuario.tp_senha = "Simetrica";

            bool retorno = usuario.gravarUsuario();
            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
                txbNome.Text = "";
                txbEmail.Text = "";
                txbSenha.Text = "";
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }



        }

        private void btnValidarS_Click(object sender, EventArgs e)
        {
            Bd banco = new Bd();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction(); //Tem que ter o transaction para ter o rollback
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text; //dizer que o comando é do tipo texo

            command.CommandText = "select senha from USUARIOS where email = @senha";
            command.Parameters.Add("@senha", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = txbLoginEmail.Text;

            string senhaCripto = (string)command.ExecuteScalar(); //ExecuteScalar serve para recuperar um único valor da consulta
                                                                  //MessageBox.Show(senhaCripto);

            if (txbLoginEmail.Text != null)
            {
                Simetrica simetrica = new Simetrica();
                string senhaDescripto = simetrica.DecryptData(senhaCripto, key);
                //MessageBox.Show(senhaDescripto);
                if (senhaDescripto == txbLoginSenha.Text)
                {
                    MessageBox.Show("Login efetuado!");
                    txbLoginEmail.Text = "";
                    txbLoginSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Dados incorretos!");
                }
            }
            else
            {
                MessageBox.Show("Precisa informar um email válido!");
            }
        }

        private void btnGravarAssimetrica_Click(object sender, EventArgs e)
        {
            Assimetrica assimetrica = new Assimetrica();
            string senha = txbSenha.Text;

            //criptografar
            string senhaCripto = assimetrica.encrypt(senha);

            Usuarios usuario = new Usuarios();
            usuario.nome = txbNome.Text;
            usuario.email = txbEmail.Text;
            usuario.senha = senhaCripto;
            usuario.tp_senha = "Assimetrica";

            bool retorno = usuario.gravarUsuario();
            if (retorno)
            {
                MessageBox.Show("Gravado com sucesso!");
                txbNome.Text = "";
                txbEmail.Text = "";
                txbSenha.Text = "";
            }
            else
            {
                MessageBox.Show("Erro ao gravar!");
            }
        }

    }
}
