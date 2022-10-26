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
        private bool porcentagemBorracha;
        private string marca;


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
        public bool PorcentagemBorracha
        {
            get { return porcentagemBorracha; }
            set { porcentagemBorracha = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public Borracha()

    }
}
