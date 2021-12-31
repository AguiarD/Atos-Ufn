using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira.Repository
{
    public class Conexao
    {
        protected SqlConnection Con;

        protected SqlCommand Cmd;

        protected SqlDataReader Dr;

        //Método para abrir a conexão com o SqlServer:
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection(@"Data Source=localhost\MSSQLSERVER01; Initial Catalog=GestaoFinanceira; User ID=sa; password=1234; language=Portuguese; Trusted_Connection=True");
                //Outra maneira de criar uma connection string (usando o Web.Config
                //Con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ProjetoCRUD"].ConnectionString);
                Con.Open();
            }
            catch (Exception e)
            {
                // Caso dê algum problema, enviar uma mensagem informando o erro:
                throw new Exception("Erro ao abrir a conexão: " + e.Message);
            }
        }

        //Método para fechar a conexão:
        protected void FecharConexao()
        {
            try
            {
                if (Con != null)
                {
                    Con.Close();
                }
            }
            catch (Exception e)
            {
                // Caso dê algum problema, enviar uma mensagem informando o erro:
                throw new Exception("Erro ao fechar a conexão: " + e.Message);
            }
        }
    }
}
