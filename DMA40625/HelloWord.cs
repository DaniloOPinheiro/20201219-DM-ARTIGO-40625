using System;

namespace DMA40625
{
    public class HelloWord
    {
        public static void MensagemNaTela()
        {
            System.Console.WriteLine("Digite seu Olá Mundo ou Hello Word");
            string frase = Console.ReadLine();

            Console.WriteLine($"Sua mensagem foi : {frase}");
            Console.WriteLine("Obrigado pela sua digitação");
        }        
    }
}