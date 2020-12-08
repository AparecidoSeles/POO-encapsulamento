using System;
using POO_encapsulamento.classes;

namespace POO_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.Parcelas = 12;

            Console.Write("O total são de : "+m.Parcelas+" parcelas , e a bandeira é : "+m.Bandeira);
            
        }
    }
}
