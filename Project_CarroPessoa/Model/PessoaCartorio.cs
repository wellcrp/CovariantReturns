using System.Collections.Generic;

namespace Project_CarroPessoa.Model
{
    public class PessoaCartorio : PessoaCarro
    {
        private Pessoa[] _pessoa;

        public PessoaCartorio(Pessoa[] pessoa)
        {
            _pessoa = pessoa;
        }

        public override IEnumerable<Pessoa> ListaVinculo() => _pessoa;
    }
}
