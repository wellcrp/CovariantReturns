using Project_CarroPessoa.Model;
using System;

namespace Project_CarroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instanciando, percorrendo e preenchendo OBJETO PessoaCartorio
            var pessoaCad = new PessoaCartorio(new Pessoa[]
            {
                new Pessoa() { PessoaId = 1, PessoaNome = "Wellington", CarroId = 1, CarroNome ="Astra", CartorioNome = "Tabelião Teste 1"},
                new Pessoa() { PessoaId = 2, PessoaNome = "Wellington Cristiano", CarroId = 2, CarroNome ="Omega", CartorioNome = "Tabelião Teste 2"},
            });

            foreach (var per in pessoaCad.ListaVinculo())
            {

                Console.WriteLine($"O cidadão {per.PessoaNome} Registrou o carro no cartorio chamado {per.CartorioNome} possui o carro {per.CarroNome}");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
