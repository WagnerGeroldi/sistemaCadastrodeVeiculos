
using System.Collections.Generic;

namespace AplicacaoComercial
{
    class Carro : Veiculo
    {
        static List<Carro> carros = new List<Carro>();
        static int MaxId = 0;

        protected float _Portas;


        #region constructors

        public Carro()
        {
            _Portas = 0;
        }

        public Carro(int id, string marca, string modelo, int ano, Cores cor, int portas)
            : base(id, marca, modelo, ano, cor)
        { 
            _Portas = portas;
        }

        public Carro(string marca, string modelo, int ano, Cores cor, int portas)
            : base(marca, modelo, ano, cor)
        {
            _Portas = portas;
        }


        #endregion

        #region gets e sets
        public float Portas
        {
            set { _Portas = value; }
            get { return _Portas; }
        }

        #endregion

        #region Acesso aos metodos

        public void Incluir()
        {

            MaxId++;
            _Id = MaxId;
            carros.Add(this);

        }
        public void Alterar()
        {

        }

        public static List<Carro> Consultar()
        {
            return Carro.carros;
        }

        public void Deletar()
        {

        }

        #endregion
    }
}
