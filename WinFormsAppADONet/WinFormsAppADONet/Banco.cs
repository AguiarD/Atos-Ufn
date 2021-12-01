﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppADONet
{
    /*
        create login usuario with password='senha';
        create user usuario from login usuario;
        Dando essa permissão para o usuario usuario
        exec sp_addrolemember 'DB_DATAREADER', 'usuario';
        exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

        Pesquisar sobre String de conexão
    */

    public class Banco
    {
        private string stringConexao = @"Data Source=localhost\MSSQLSERVER01; Initial Catalog=ADONet; User ID=usuario; password=senha; language=Portuguese";

        private SqlConnection cn;

        private void conexao() //vincular a string com o cn, bm inicia o CN 
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {

                //fazer algo se deu erro
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {                
                cn.Close();
            }
            catch (Exception ex)
            {

                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                //conexao();
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt); // adaptar preenche o datatable com os dados do command. (Fill = preencher)

                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
