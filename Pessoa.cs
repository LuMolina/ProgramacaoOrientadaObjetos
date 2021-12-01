using System;

namespace ProgramacaoOrientadaObjetos.Cadastros
{
    public class Pessoa
    {
        public int Codigo { get; set; }

        public string? Nome { get; set; }

        public string? Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }


        public Pessoa()
        {
        }
        public Pessoa(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
            //this acessa membros dentro da própria classe. 
            //método sobrecarga e construtor.

        }
public string CalculaIdade() //chamado de assinatura do método: teor de visibilidade, tipo de retorno do método, nome do método, por fim os parâmetros. Aqui parâmetros vazios.
//método para calcular idade. Se tem parênteses é método, se tem get e set é propriedade.
{
int anos = DateTime.Now.Year - this.DataNascimento.Year;
if(this.DataNascimento.Month > DateTime.Now.Month)
anos--;

return $"{this.Nome} tem {anos} de idade. ";

}

    }


}