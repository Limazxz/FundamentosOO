using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Produto
    {
        //atributos
        public int codigo { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public int estoque { get; set; }

        //metodos
        public void QuantidadeEstoque()
        {
            Console.WriteLine("A quantidade em estoque é: " + this.estoque);
        }
    }
}
