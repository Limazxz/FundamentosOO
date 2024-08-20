using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Funcionario : Pessoa
    {
        //atributos
        public string cargo { get; set; }
        public double salario { get; set; }

        //metodos
        public void apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + this.nome + ", tenho " + this.idade + " anos de idade, sou " + this.cargo + " e meu salario é de R$ " + this.salario);
        }
    }
}
