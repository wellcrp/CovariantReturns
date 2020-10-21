using Project_CarroPessoa.Model;
using System;

namespace Project_CarroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instanciando, percorrendo e preenchendo OBJETO PessoaCartorio

            var pessoaCad = new PessoaCartorio(new Pessoa[] {
                new Pessoa { PessoaNome ="Wellington" },
                new Pessoa { PessoaNome ="Wellington Cristiano" },
            });

            foreach (var per in pessoaCad.ListaRegistro())
            {
                Console.WriteLine($"O cidadão {((Pessoa)per).PessoaNome}");
            }

            var carroCart = new CarroCartorio(new Carro[] {
                new Carro {CarroNome = "Corsa", CartorioNome = "Cartorio 1"},
                new Carro { CarroNome = "Fiesta", CartorioNome = "Cartorio 2"},
            });

            foreach (var car in carroCart.ListaRegistro())
            {
                Console.WriteLine($"comprou o carro de nome {((Carro)car).CarroNome} Registrou o carro no cartorio na cidade de {car.CartorioNome} na cidade {car.CartorioCidade}");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
