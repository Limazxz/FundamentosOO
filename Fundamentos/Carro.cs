using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Carro
    {
        //atributos
        public string marca { get; set; }
        public string modelo { get; set; }
        public int velocidade { get; set; }
        //metodos
        public void acelerar()
        {
            this.velocidade += 5;
            Console.WriteLine("Velocidade atual é de: " + this.velocidade + "km/h");
        }
        public void desacelerar()
        {
            this.velocidade -= 5;
            Console.WriteLine("Velocidade atual é de: " + this.velocidade + "km/h");
        }

    }
}
