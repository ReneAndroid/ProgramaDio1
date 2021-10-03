using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDio
{
    public class Filme
    {
        public string Nome { get; set; }
        public int ano { get; set; }

        public double nota { get; set; }

        public Filme(string nome, int Ano, double Nota)
        {
            Nome = nome;
            ano = Ano;
            nota = Nota;
        }
    }
}
