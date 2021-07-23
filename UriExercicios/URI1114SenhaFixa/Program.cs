using System;

namespace URI1114SenhaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int senhaCorreta = 2002;
            int senha;

            senha = int.Parse(Console.ReadLine());

            while(senha != senhaCorreta){
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            if(senha == senhaCorreta){
                Console.WriteLine("Acesso Permitido");
            }



        }
    }
}
