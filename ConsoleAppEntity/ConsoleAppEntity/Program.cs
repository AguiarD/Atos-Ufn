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
                @"Informe a opção:
                1 para criar uma pessoa,
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

                case 3:
                    Console.WriteLine("Informe o ID da pessoa: ");
                    int idPess = int.Parse(Console.ReadLine());
                    Pessoa pess = contexto.Pessoas.Find(idPess);

                    Console.WriteLine("Insira o novo email: ");
                    Email emailNovo = new Email();
                    emailNovo.email = Console.ReadLine();

                    if (pess.Emails == null)
                    {
                        pess.Emails = new List<Email>();
                    }

                    pess.Emails.Add(emailNovo);

                    contexto.Pessoas.Update(pess);
                    contexto.SaveChanges();

                    break;

                case 4:
                    Console.WriteLine("Informe o ID da pessoa: ");
                    int idExc = int.Parse(Console.ReadLine());
                    Pessoa pExc = contexto.Pessoas.Find(idExc);

                    Console.WriteLine("Confirma a exclusão de " + pExc.Nome);
                    Console.WriteLine(" e dos seus emails: ");

                    foreach (Email item in pExc.Emails)
                    {
                        Console.WriteLine("   " + item.email);
                    }

                    Console.WriteLine("1 -> SIM ----- 2 -> NAO");
                    int retorno = int.Parse(Console.ReadLine());

                    if (retorno == 1)
                    {
                        contexto.Pessoas.Remove(pExc);
                        contexto.SaveChanges();
                    }

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
