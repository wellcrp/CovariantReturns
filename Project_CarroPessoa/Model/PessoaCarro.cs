using System.Collections.Generic;

namespace Project_CarroPessoa.Model
{
    public abstract class PessoaCarro
    {
        public abstract IEnumerable<Pessoa> ListaVinculo();
    }
}
