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

Console.WriteLine("Digite a sua data de nascimento: (dd/MM/aaaa) ");
string? textoDataNascimento = Console.ReadLine();
int ano = Convert.ToInt32(textoDataNascimento?.Substring(6, 4));
int mes = Convert.ToInt32(textoDataNascimento?.Substring(3, 2));
int dia = Convert.ToInt32(textoDataNascimento?.Substring(0, 2));
//subrtring pega o índice inicial, quantidade de carateres que ele quer pegar a partir dali.

Pessoa novoObjetoPessoa = new("Luciane", "Molina", new DateTime(ano, mes, dia));


Console.WriteLine($"O nome da pessoa do novo objeto é: {novoObjetoPessoa.Nome} {novoObjetoPessoa.Sobrenome}. {novoObjetoPessoa.CalculaIdade()} ");






        }
    }
}