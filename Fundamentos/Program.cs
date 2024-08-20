
using Fundamentos;

internal class Program
{

    private static void Main(string[] args)
    {
        ////instanciar um objeto do tipo aluno
        //Aluno aluno1 = new Aluno();

        ////iserir informações no objeto 
        //aluno1.RM = "1234DS";
        //aluno1.nome = "Pedro";
        //aluno1.email = "silvaelima557@gmail.com";
        //aluno1.nascimento = new DateOnly(2008, 03, 17);

        ////imprimir na tela
        //Console.WriteLine("Aluno1");
        //Console.WriteLine("RM: " + aluno1.RM);
        //Console.WriteLine("Nome: " + aluno1.nome);
        //Console.WriteLine("E-mail: " + aluno1.email);
        //Console.WriteLine("Nascimento: " + aluno1.nascimento);
        //Console.WriteLine("====================================");
        //Aluno aluno2 = new Aluno();
        //aluno2.RM = "4567DS";
        //aluno2.nome = "Paulo";
        //aluno2.email = "silvaelima557@gmail.com";
        //aluno2.nascimento = new DateOnly(2008, 03, 17);

        ////instanciar um objeto do tipo produto
        //Produto p1 = new Produto();
        //p1.codigo = 123456;
        //p1.nome = "Coca-Cola 2 litros";
        //p1.preco = 12.99;
        //p1.estoque = 96;
        ////chamar o metodo estoque
        //p1.QuantidadeEstoque();

        //p1.estoque = 85;
        ////chamar o metodo estoque
        //p1.QuantidadeEstoque();
        //Console.WriteLine("=====================================");
        //Console.WriteLine("");


        ////instanciar um objeto do tipo carro
        //Carro carro1 = new Carro();
        //carro1.marca = "Pagani";
        //carro1.modelo = "Zonda R";
        //carro1.velocidade = 150;
        //carro1.acelerar();
        //Console.WriteLine("=====================================");
        //Pessoa pessoa1 = new Pessoa();
        //pessoa1.nome = "Roberval";
        //pessoa1.idade = 17;
        //pessoa1.envelhecer(1);
        //pessoa1.envelhecer(12);
        //Console.WriteLine("=====================================");
        //Funcionario func1 = new Funcionario();
        //func1.nome = "Roberval Andrade";
        //func1.idade = 87;
        //func1.cargo = "Menor Aprendiz";
        //func1.salario = 574.99;
        //func1.apresentar();
        ////livro livro1 = new livro();
        ////livro1.titulo = "um dia...";
        ////livro1.editora = "Editora FON";
        ////livro1.autor = "Arnold";
        ////livro1.anoLancamento = 2021;

        ////livro livro2 = new livro();
        ////livro2.titulo = "dois dias...";
        ////livro2.editora = "Editora Eudine";
        ////livro2.autor = "Pedro";
        ////livro2.anoLancamento = 2008;

        ////livro livro3 = new livro();
        ////livro3.titulo = "tres dias";
        ////livro3.editora = "Editora Serem";
        ////livro3.autor = "Paulo";
        ////livro3.anoLancamento = 1998;
        //Console.WriteLine("=====================================");
        ////Animal animal1 = new Animal();

        ////animal1.Especie = "Cachorro";

        ////animal1.emitirSom();

        ////Console.WriteLine("O Animal " + animal1.Especie + " emitiu um Som");

        Console.WriteLine("=====================================");
        Gato gato = new Gato();
        gato.Nome = "Euclídes";
        Console.WriteLine(gato.Nome + " faz: ");
        gato.emitirSom();
        Console.WriteLine("=====================================");
        Galinha gal = new Galinha();
        gal.Nome = "Gertrudes";
        Console.WriteLine(gal.Nome + " faz: ");
        gal.emitirSom();
        Console.WriteLine("=====================================");
        Porco porco = new Porco();
        porco.Nome = "Josias";
        Console.WriteLine(porco.Nome + " faz: ");
        porco.emitirSom();
    }
}