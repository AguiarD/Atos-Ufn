using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_DadosLocais.Models
{
    public static class Dados
    {
        //Dados da aplicação
        private static List<Cliente> LISTA_CLIENTES = new List<Cliente>();
        public static List<Cliente> todos_os_clientes()
        {
            //Todos os clientes da aplicacao
            return LISTA_CLIENTES;
        }

        public static void adcionar_cliente(Cliente clienteTemp)
        {
            //buscar o id disponivel
            int id = 0;
            if (LISTA_CLIENTES.Count() != 0) 
            {
                id = LISTA_CLIENTES.Last<Cliente>().Id + 1;
            }

            //guardar os dados do novo cliente
            clienteTemp.Id = id;
            LISTA_CLIENTES.Add(clienteTemp);
        }

        public static Cliente dados_cliente(int id)
        {
            //devolve os dados do cliente selecionado
            Cliente clienteTemp = LISTA_CLIENTES.Where(i => i.Id == id).FirstOrDefault();
            return clienteTemp;
        }

        public static void editar_cliente(Cliente c)
        {
            //editar os dados do cliente selecionado
            LISTA_CLIENTES.First<Cliente>(i => i.Id == c.Id).Nome = c.Nome;
            LISTA_CLIENTES.First<Cliente>(i => i.Id == c.Id).Telefone = c.Telefone;
        }

        public static void eliminar_cliente(int id)
        {
            var clienteTemp = LISTA_CLIENTES.First<Cliente>(i => i.Id == id);
            LISTA_CLIENTES.Remove(clienteTemp);
        }
    }
}
