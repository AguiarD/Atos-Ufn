// See https://aka.ms/new-console-template for more information
using ConsoleAppSingleton;

Console.WriteLine("Hello, World!");

Singleton s1 = Singleton.getInstance();
Console.WriteLine(Singleton.nome);

Console.WriteLine();

Singleton s2 = Singleton.getInstance();

if (s1 == s2)
{
    Console.WriteLine("As instancias são as mesmas");
}
