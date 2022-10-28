using System.Runtime.CompilerServices;

namespace Models
{
    public class Pneu
    {
        private int aro;
        private string marca;
        private bool furado;
        private bool estourado;
        private int psi;
        private double percentualBorracha;
        private int rotacao;

        public int Aro
        {
            get { return aro; }
            set { aro = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public bool Furado
        {
            get { return furado; }
            set { furado = value; }
        }
        public int Psi
        {
            get { return psi; }
            set { psi = value; }
        }
        public bool Estourado
        {
            get { return estourado; }
            set { estourado = value; }
        }
        public double PercentualBorracha
        {
            get { return percentualBorracha; }
            set { percentualBorracha = value; }
        }

        public int Rotacao
        {
            get { return rotacao; }
            set { rotacao = value; }    
        }

        public Pneu(int _aro, string _marca)    
        {
            Aro = _aro;
            Marca = _marca;
            Furado = false;
            Estourado = false;
            psi = 33;
            PercentualBorracha = 100;
            Rotacao = 0;
        }
        public void Girar( int _rotacao)
        {
            rotacao += _rotacao;
            gastarBorracha(_rotacao / 100);
        }
        public void Frear( int _abatimento)
        {
            rotacao -= _abatimento;
            gastarBorracha(_abatimento / 100);
            if(rotacao < 0)
            {
              rotacao = 0;
               
            }
        }
        public void Furar()
        {
            Furado = true;
            psi = 0;
        }
        public void Remendar()
        {
            Furado = false;
        }
        private void gastarBorracha(double _quantidade)
        {
            percentualBorracha -= _quantidade;

           if( percentualBorracha == 0)
                Estourar();
            
        }
        private void Estourar()
        {
            Estourado = true;
            psi = 0;
            percentualBorracha = 0;
        }
        public void Exibir()
        {
        Console.WriteLine("aro" + Aro);
        Console.WriteLine("marca: " + Marca);
        Console.WriteLine("furado: " + Furado);
        Console.WriteLine("estourado: " + Estourado);
        Console.WriteLine("psi: " + Psi);
        Console.WriteLine("percentualBorracha: " + PercentualBorracha);
        Console.WriteLine("rotacao: " + Rotacao);
        }
    }
}