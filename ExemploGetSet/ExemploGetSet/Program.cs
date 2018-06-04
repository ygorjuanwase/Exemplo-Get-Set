using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro dogao = new Cachorro();
            dogao.SetNome("aaaaaaaaaaaaaa");
            dogao.SetAltura(1.50);
            dogao.SetPeso (50);
            dogao.SetRaca  ("rotwailer");

            Console.WriteLine(dogao.GetNome());
            Console.WriteLine(dogao.GetAltura());
            Console.WriteLine(dogao.GetPeso());
            Console.WriteLine(dogao.GetRaca());
        }
    }
}
