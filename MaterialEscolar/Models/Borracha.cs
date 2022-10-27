using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Borracha
    {
        private string cor;
        private int tamanho;
        private double peso;
        private bool semBorracha;
        private float porcentagemBorracha;
        private string marca;
        private bool gastarBorracha;


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
        public bool SemBorracha
        {
            get { return semBorracha; }
            set { semBorracha = value; }
        }
        public float PorcentagemBorracha
        {
            get { return porcentagemBorracha; }
            set { porcentagemBorracha = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public bool GastarBorracha
        {
            get { return gastarBorracha; } 
            set { gastarBorracha = value; }
        }
        public Borracha(string _cor, int _tamanho, double _peso, string _marca)
        {
            Cor = _cor;
            Tamanho = _tamanho;
            Peso = _peso;
            Marca = _marca;
            PorcentagemBorracha = 100;
            
        }
        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tamanho: " + Tamanho);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Marca: " + Marca);
           
        }
        public void BorrachaGasta()
        {
            SemBorracha = true;
        }
        public void Apagar()
        {
            GastarBorracha = true ;
        }
        public void Apagando(string _apagando)
        {
            if (this.SemBorracha == true)
            {
                Console.WriteLine("Voce nao tem mais Borracha para apagar");
                return;
            }
            if(this.GastarBorracha == true )
            {
                PorcentagemBorracha -= 3;
                Console.WriteLine("Porcentagem Gasta:  " + PorcentagemBorracha);
                Console.WriteLine("Apangando o erro");
                return;
            }
            Console.WriteLine(_apagando);

        }
    }
}
