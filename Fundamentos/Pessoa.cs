using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Pessoa
    {
        //atributos
        public string nome { get; set; }
        public int idade { get; set; }
        //metodos
        public void envelhecer(int anos)
        {
            this.idade += anos;
            Console.WriteLine("a idade atual é: " + this.idade + " 5anos de idade");
        }

    }
}
