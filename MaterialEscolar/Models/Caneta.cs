namespace Models
{


    public class Caneta

    {
        private string cor;
        private int tamanho;
        private double peso;
        private bool tampada;
        private bool caida;
        private bool estourada;
        private int percentualcarga;
        private string marca;
        private string material;
        private string tipoPonta;
        private double ponta;

       public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public bool Tampada
        {
            get { return tampada; }
            set { tampada = value; }
        }
        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
        }
        public bool Estourada
        {
            get { return estourada; }
            set { estourada = value; }
        }
        public int percentualCarga
        {
            get { return percentualcarga; }
            set { percentualcarga = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string TipoPonta
        {
            get { return tipoPonta; }
            set { tipoPonta = value; }
        }
        public double Ponta
        {
            get { return ponta; }
            set { ponta = value; }
        }



        public Caneta(string _cor, int _tamanho, double _peso, string _marca, string _material, string _tipoPonta, double _ponta
            )
        {
            Cor = _cor;
            tamanho = _tamanho;
            peso = _peso;
            marca = _marca;
            material = _material;
            ponta = _ponta;
            TipoPonta = _tipoPonta;
            percentualCarga = 100;
        }

        public void Exibir()
        {
            Console.Write("Cor: " + Cor);
            Console.WriteLine("\nTamanho: " + Tamanho);
            Console.WriteLine("Peso :" + Peso);
            Console.WriteLine("Tampada: " + Convert.ToString(Tampada));
            Console.WriteLine("Caida" + Convert.ToString(Caida));
            Console.WriteLine("Estourada: " + Convert.ToString(Estourada));
            Console.WriteLine("% da Carga: " + percentualCarga);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Ponta: " + Ponta);
            Console.WriteLine("Tipo de Ponta: " + TipoPonta);
        }

        public void Cair()
        {
            Caida = true;

        }

        public void PegardoChao()
        {
            Caida = true;

        }

        public void Tampar()
        {
            Tampada = true;

        }

        public void Destampar()
        {
            Tampada = false;

        }
        public void Escrever(string _texto)
        {
            if (this.Tampada == true)
            {

                Console.WriteLine("Voce nao pode escrever pois ela esta tampada");
                return;
            }
            if (this.Caida == true)
            {
                Console.WriteLine("Voce nao pode escrever pois sua caneta caiu ");
                return;
            }
            if (percentualCarga == 0)
            {
                Console.WriteLine("Voce não pode escrever pois a caneta esta sem tinta");
                return;
            }
            Console.WriteLine(_texto);
            GastarTinta();
        }
         private void GastarTinta()
        {
            percentualCarga -= 10;
        }


    }
}
