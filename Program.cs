        using System;
        using ProgramacaoOrientadaObjetos.Cadastros;

namespace ProgramacaoOrientadaObjetos
{
public class Program
    {
public static void Main(string[] args)
        {
Pessoa objetoPessoa = new(); //criei objeto da classe pessoa.
objetoPessoa.Nome = "Luciane";
objetoPessoa.Sobrenome = "Molina";
//atribuindo valor a uma propriedade. Set em ação. Set é pra escrita.
Console.WriteLine($"O nome da pessoa é: {objetoPessoa.Nome} {objetoPessoa.Sobrenome}");
//get é responsável pela leitura dessas propriedades. 


Pessoa novoObjetoPessoa = new("Luciane", "Molina", new DateTime(1982, 12, 08));
Console.WriteLine($"O nome da pessoa do novo objeto é: {novoObjetoPessoa.Nome} {novoObjetoPessoa.Sobrenome}. {novoObjetoPessoa.CalculaIdade()} ");






        }
    }
}