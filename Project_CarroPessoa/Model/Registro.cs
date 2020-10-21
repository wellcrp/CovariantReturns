using System.Collections.Generic;

namespace Project_CarroPessoa.Model
{
    public abstract class Registro
    {
        public string Descricao { get; set; }
        public abstract IEnumerable<Cartorio> ListaRegistro();
    }
}
