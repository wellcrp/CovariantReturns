using System.Collections.Generic;

namespace Project_CarroPessoa.Model
{
    public class CarroCartorio : Registro
    {
        private Carro[] _carro;
        public CarroCartorio(Carro[] carro) => (_carro) = (carro);
        public override IEnumerable<Cartorio> ListaRegistro() => _carro;
    }
}
