// See https://aka.ms/new-console-template for more information
using ConsoleAppFactoryMethod;

Console.WriteLine("Oi pessoal, estou aqui no programa para testar o padrão factory method");


/*PFisica pf = new PFisica("Teste pf");
Console.WriteLine("Nome PF" + pf.Nome);
PJuridica pj = new PJuridica("Teste pj");
Console.WriteLine("Nome PJ" + pj.Nome);*/


FactoryPessoa fp1 = new FactoryPessoa();
Pessoa p1 = fp1.getPessoa("Douglas PJ", "PJ");
Console.WriteLine(p1.Nome);

Console.WriteLine();

FactoryPessoa fp2 = new FactoryPessoa();
Pessoa p2 = fp2.getPessoa("Douglas PF", "PF");
Console.WriteLine(p2.Nome);

Console.WriteLine();

Pessoa p3 = fp1.getPessoa("Maggie", "Cadela");  //como "cadela" é != de "PF" ou "PJ", retorna null
Console.WriteLine(p3.Nome);


