using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0 , 0,"Lucas Ribeiro");
            Conta suaConta = new Conta(TipoConta.PessoaFisica, 0 , 0,"Neymar");
            Console.WriteLine(minhaConta.ToString());
            minhaConta.Depositar(100);
            minhaConta.Sacar(150);
            minhaConta.Transferir(60,suaConta);
            Console.WriteLine(minhaConta.ToString());
            Console.WriteLine(suaConta.ToString());
            
        }
    }
}
