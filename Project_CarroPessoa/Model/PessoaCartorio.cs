using System.Collections.Generic;

namespace Project_CarroPessoa.Model
{
    public class PessoaCartorio : Registro
    {
        private Pessoa[] _pessoa;
        public PessoaCartorio(Pessoa[] pessoa) => (_pessoa) = (pessoa);
        public override IEnumerable<Cartorio> ListaRegistro() => _pessoa;
    }
}
