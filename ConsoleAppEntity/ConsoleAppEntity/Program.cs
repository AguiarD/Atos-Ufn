using ConsoleAppEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                @"Informe 1 para criar uma pessoa,
                2 para alterar o nome,
                3 para inserir um email,
                4 para excluir a pessoa,
                5 para consultar as pessoas (todas),
                6 para consultar pelo ID"
                );
            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Pessoa p = new Pessoa();
                        Console.WriteLine("Insira o nome da pessoa:");
                        p.Nome = Console.ReadLine();

                        Console.WriteLine("Insira o email da pessoa:");
                        Email email = new Email();                        
                        email.email = Console.ReadLine();

                        p.Emails = new List<Email>(); //iniciar a lista

                        p.Emails.Add(email); //adcionar o email na lista

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                    break;

                case 2:
                    Console.WriteLine("Informe o ID da pessoa: ");
                    int idPessoaAlt = int.Parse(Console.ReadLine());
                    Pessoa pAlt = contexto.Pessoas.Find(idPessoaAlt);
                    Console.WriteLine("Informe o novo nome: ");
                    pAlt.Nome = Console.ReadLine();
                    contexto.Pessoas.Update(pAlt);
                    contexto.SaveChanges();
                    break;

                case 5:
                    List<Pessoa> pessoas = new List<Pessoa>();
                    pessoas = (from Pessoa p in contexto.Pessoas select p).Include(e => e.Emails).ToList<Pessoa>();
                    foreach (Pessoa pessoaItem in pessoas)
                    {
                        Console.WriteLine(pessoaItem.Nome);
                        foreach (Email emailItem in pessoaItem.Emails)
                        {
                            Console.WriteLine("Email: " + emailItem.email);
                            Console.WriteLine();
                        }
                    }

                    break;

                case 6:
                    Console.WriteLine("Informe o ID da pessoa: ");
                    int idPessoa = int.Parse(Console.ReadLine());
                    Pessoa pe = contexto.Pessoas.Include(pe => pe.Emails).FirstOrDefault(pe => pe.id == idPessoa);
                    Console.WriteLine(pe.Nome);

                    foreach (Email emailItem in pe.Emails)
                    {
                        Console.WriteLine("Email: " + emailItem.email);
                    }
                    Console.WriteLine();

                    break;
                default:
                    break;
            }
        }
    }
}
