using System;

namespace CaixaelEtronicoUp
{
    class Program
    {
        public static ConsoleKeyInfo Keyinfo;
        static void Main(string[] args)
        {
            

            ContaCorrente [] conta = new ContaCorrente[5];

            conta[0].titular = new Cliente();

             
            
           
           
          if (conta == null)
          {
             for (int posição = 0; posição < conta.Length; posição++)
             {
                 Console.WriteLine("login :");
                 conta[1].titular.nome = Console.ReadLine();
                 Console.Write("senha :");
                 conta[1].titular.senha = Console.ReadLine();
                 Console.WriteLine(" F1 para criar conta ");
             }
                    
                    Keyinfo = Console.ReadKey();
           }
            if (Keyinfo.Key == ConsoleKey.F1)
            {
               Console.WriteLine("digite seu nome: ");
               conta[0].titular.nome = Console.ReadLine();
               Console.WriteLine("digite sua senha: ");
               conta[0].titular.senha = Console.ReadLine();
               Console.WriteLine("digite sua CPF");
               conta[0].titular.cpf = Console.ReadLine();

            }
                
            
            
           

        }
        
    }
}
