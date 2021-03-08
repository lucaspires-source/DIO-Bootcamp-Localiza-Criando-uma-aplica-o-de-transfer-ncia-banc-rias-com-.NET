using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta();
            Conta suaConta = new Conta();
            suaConta.Nome = "Neymar";
            minhaConta.Nome = "Lucas";
            Console.WriteLine(minhaConta.Nome);
            Console.WriteLine(suaConta.Nome);
        }
    }
}
