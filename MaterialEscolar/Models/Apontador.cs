using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Apontador
    {
        private string cor;
		private string marca;
		private int tamanho;
		private bool semLamina;
		private bool laminaAfiada;

        public string Cor
		{
			get { return cor; }
			set { cor = value; }
		}
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public bool SemLamina
        {
            get { return semLamina; }
            set { semLamina = value; }
        }
        public bool LaminaAfiada
        {
            get { return laminaAfiada; }
            set { laminaAfiada = value; }
        }

        public Apontador(string _cor, string _marca, int _tamanho)
        {
            Cor = _cor;
            Marca = _marca;
            Tamanho = _tamanho;
        }
        public void Mostrar()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Tamanho: " + Tamanho);
            Console.WriteLine("Peso: " + Convert.ToString(SemLamina));
            Console.WriteLine("Material: " + Convert.ToString (LaminaAfiada));
        }
        public void FaltaLamina()
        {
            SemLamina = true;
        }
        public void LaminaBoa()
        {
            LaminaAfiada = true;
        }
        public void Apontar(string _texto)
        {
            if(this.SemLamina == true)
            {
                Console.WriteLine("Nao e possivel usar o apontador pois falat a lamina");
                return;
            }
            if(this.LaminaAfiada == true)
            {
                Console.WriteLine("Apontando o seu lapis aguarde...");
                return;
            }
            Console.WriteLine(_texto);
        }
    }
}
