using System;

namespace ConsoleAppCriptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Utilizando chaves simétricas e assimetricas");

            /*AES significa Advanced Encryption Standard e foi desenvolvido para atualizar o algoritmo DES original.
            Entre alguns dos aplicativos mais comuns de algoritmo AES incluem-se aplicativos de mensagens, como o Signal ou WhatsApp, e
            o programa de compactação de arquivos WinZip.*/

            Simetrica s = new Simetrica();
            string dadoCripto;
            string dadoCripto2;
            string msg, msg2;
            string msgDescripto, msgDescripto2;


            /* -----------------------Assimetrica ---------------------------------*/

            Console.WriteLine("Utilizando chaves assimetricas");

            Assimetrica a = new Assimetrica();

            Console.WriteLine("Digite uma mensagem para ser criptografada");
            msg = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite outra mensagem para ser criptografada");
            msg2 = Console.ReadLine();

            Console.WriteLine();

            //Criptografar
            dadoCripto = a.encrypt(msg);
            Console.WriteLine("Mensagem cripto 1 = " + dadoCripto);

            Console.WriteLine();

            dadoCripto2 = a.encrypt(msg2);
            Console.WriteLine("Mensagem cripto 1 = " + dadoCripto2);

            Console.WriteLine();

            //Descriptografar
            msgDescripto = a.decrypt(dadoCripto);
            Console.WriteLine("Mensagem descriptografada: " + msgDescripto);

            Console.WriteLine();

            msgDescripto2 = a.decrypt(dadoCripto2);
            Console.WriteLine("Mensagem descriptografada: " + msgDescripto2);


            /* -------------------------------- Simetrica -------------------------
            Console.WriteLine("Utilizando chaves simétricas"); 
            Console.WriteLine("Algoritmo AES");


            Console.WriteLine("Digite uma mensagem para ser criptografada: ");
            msg = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite outra mensagem para ser criptografada: ");
            msg2 = Console.ReadLine();

            Console.WriteLine();

            //criptografar
            dadoCripto = s.EncryptData(msg, "atoS");
            Console.WriteLine("Mensagem criptografada: " + dadoCripto);

            Console.WriteLine();

            dadoCripto2 = s.EncryptData(msg, "UFN");
            Console.WriteLine("Mensagem criptografada: " + dadoCripto2);

            //Descriptografar

            msgDescripto = s.DecryptData(dadoCripto, "atoS");
            Console.WriteLine("Msg 1 descripto = " + msgDescripto);

            Console.WriteLine();

            msgDescripto2 = s.DecryptData(dadoCripto2, "UFN");
            Console.WriteLine("Msg 2 descripto = " + msgDescripto2);*/


        }
    }
}
