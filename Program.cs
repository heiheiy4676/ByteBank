using System;

namespace CaixaelEtronicoUp
{
    class Program
    {
        public static ConsoleKeyInfo Keyinfo;
        static void Main(string[] args)
        {



            ContaCorrente conta1 = new ContaCorrente();
            Clienteu cliente = new Clienteu();

            do
            {
                Console.WriteLine("pressione F1 para criar conta");
                Console.Write("login:");
                cliente.login = Convert.ToString(Console.ReadLine());
                Console.Write("senha:");
                cliente.senha = Convert.ToString(Console.ReadLine());
               

                Keyinfo = Console.ReadKey();


                if (Keyinfo.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("digite login");
                    cliente.login = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite senha");
                    cliente.senha = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite seu cpf");
                    cliente.cpf = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("digite seu nome");
                    cliente.nome = Convert.ToString(Console.ReadLine());

                }
                Console.WriteLine("pressione ESC para sair ou qualquer tecla para continuar");
                Keyinfo = Console.ReadKey();
            } while (Keyinfo.Key != ConsoleKey.Escape);
        }

    }
}
