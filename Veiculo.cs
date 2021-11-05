
namespace AplicacaoComercial
{
    class Veiculo
    {
        public enum Cores { Branca, Vermelho, Preto };


        protected int _Id;
        protected string _Marca;
        protected string _Modelo;
        protected int _Ano;
        protected Cores _Cor;

        #region constructors

        public Veiculo()
        {

        }

        public Veiculo(int id, string marca, string modelo, int ano, Cores cor)
        {
            _Id = id;
            _Marca = marca;
            _Modelo = modelo;
            _Ano = ano;
            _Cor = cor;

        }

        public Veiculo(string marca, string modelo, int ano, Cores cor)
        {
            _Id = 0;
            _Marca = marca;
            _Modelo = modelo;
            _Ano = ano;
            _Cor = cor;

        }


        #endregion

        #region gets e sets


        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        public string Marca
        {
            set { _Marca = value; }
            get { return _Marca; }
        }

        public string Modelo
        {
            set { _Modelo = value; }
            get { return _Modelo; }
        }

        public int Ano
        {
            set { _Ano = value; }
            get { return _Ano; }
        }

        public Cores Cor
        {
            set { _Cor = value; }
            get { return _Cor; }
        }

        #endregion

        

    }
}
