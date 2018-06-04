using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Cachorro
    {
        private string Nome;
        private string Raca;
        private double Peso;
        private double Altura;
        // guardar determinada informaçao
        public void SetNome(string nome)
        {
            if (Nome.Count() < 3)
            {
                throw new Exception("Nome deve conter 3 letras");
            }
            Nome = nome;
            if(Nome.Count() > 40)
            {
                throw new Exception("Nome deve conter no máximo 40 letras");
            }
            Nome = nome;
        }
        public void SetAltura(double altura)
        {
            if (altura <= 0)
                {
                    throw new Exception("Altura devev ser maior que 0");
                }
                if(altura > 2)
                {
                    throw new Exception("Altura deve ser menor que 2 metros");
                }
                Altura = altura;
        }
        public void SetPeso(double peso)
        {
            if (peso <= 0)
            {
                throw new Exception("peso deve ser maior que 0");
            }
            if (peso > 150 )
            {
                throw new Exception("peso deve ser menor que 150kg");
            }
            Peso = peso;
        }
        public void SetRaca(string raca)
        {
            if (raca.Count() < 3)
            {
                throw new Exception("nome da raca deve conter mais de 3 caracteres");
            }
            if (raca.Count() > 40)
            {
                throw new Exception("Nome da raca deve conter mais de 40 caracteres");
            }
            Raca = raca;
        }
        public string GetNome()
        {
            return Nome;
        }

        public double GetAltura()
        {
            return Altura;
        }
        public double GetPeso()
        {
            return Peso;
        }
        public string GetRaca()
        {
            return Raca;
        }


        // peso /////min: 0,1 max: 150
        //raca min: 3 max: 40
    
    }
}
