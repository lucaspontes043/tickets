using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ticketValido;
            string[] tickets = { "580624", "560140", "560137", "560101", "631497", "560133" };

            while (true)
            {
                Console.WriteLine("Sistema de Validação de Tickets");
                Console.WriteLine();
                Console.Write("Informe o ticket: ");
                string ticket = Console.ReadLine();
                ticketValido = false;
                //#DESAFIO: Verificar se o ticket é valido!

                for (int item = 0; item < tickets.Length; item++)
                {
                    if (tickets[item] == ticket)
                    {
                        ticketValido = true;
                        tickets[item] = null;
                        break;
                    }

                }
                if (ticketValido)
                    Console.WriteLine("Ticket Valido. entrada liberada!");
                else
                    Console.WriteLine("Ticket Invalido. entrada bloqueada!");
                Console.WriteLine("PALMEIRAS NÃO TEM MUNDIAL");
                Console.ReadKey();
                Console.Clear();
            }


        }
    }
}
