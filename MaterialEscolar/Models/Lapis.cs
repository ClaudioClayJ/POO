using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Lapis
    {
        private string cor;
        private int tamanho;
        private double peso;
        private bool caida;
        private string marca;
        private string material;
        private bool comPonta;
        private bool semPonta;
        private bool apontador;

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
        public bool Caida
        {
            get { return caida; }
            set { caida = value; }
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
        public bool ComPonta
        {
            get { return comPonta; }
            set { comPonta = value; }
        }
        public bool SemPonta
        {
            get { return semPonta; }
            set { semPonta = value; }
        }
        public bool Apontador
        {
            get { return apontador; }
            set { apontador = value; }
        }
        public Lapis(string _cor, int _tamanho, double _peso, string _marca, string _material)
        {
            Cor = _cor;
            Tamanho = _tamanho;
            Peso = _peso;
            Marca = _marca;
            Material = _material;
        }
        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tamanho: "+ Tamanho);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Material: " + Material);
            //Console.WriteLine("Com Ponta" + Convert.ToString(ComPonta));
            //Console.WriteLine("Sem Ponta" + Convert.ToString(SemPonta));
            //Console.WriteLine("Apontar" + Convert.ToString(Apontador));
        }
        public void Cair()
        {
            Caida = true;
        }
    
           public void Ponta()
        {
            ComPonta = true;
        }
           public void Desapontado()
        {
            SemPonta = true;
        }
         public void Desgastado()
        {
            Apontador = true;
        }
        public void Escrever(string _texto)
        {
           if(this.ComPonta == true)
            {
                Console.WriteLine(" Esta certo com o codigo");
                return;
            }
           if(this.SemPonta == true)
            {
                Console.WriteLine("Seu lapis esta sem ponta");
                return;
            }
           if(this.Apontador == true)
            {
                Console.WriteLine("Seu lapis precisa apontar");
                return;
            }
            Console.WriteLine(_texto);
                
        }
    }
}
