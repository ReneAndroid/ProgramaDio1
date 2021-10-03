using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDio
{
    class Program
    {
        //static List<Filme> filmes;
        static void Main(string[] args)
        {
            List<Filme> filmes = new List<Filme>();
            
            string continuar = "1";
            int contador = 0;
           
          
            string  voltar = "1";


            do
            {
                Console.WriteLine("Digite : 1 para adicionar filme| 2 listar | 3 para remover");
                int crud = int.Parse(Console.ReadLine());
                switch (crud)
                {
                    case 1:

                        while (continuar == "1")
                        {
                            Console.WriteLine("Filme de numero : " + (contador + 1) + " Digite o nome do seu filme ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Filme de numero : " + (contador + 1) + " Digite o ano do seu filme ");
                            int ano = int.Parse(Console.ReadLine());
                            Console.WriteLine("Filme de numero : " + (contador + 1) + " Digite a nota do seu filme ");
                            double nota = double.Parse(Console.ReadLine());
                            filmes.Add(new Filme(nome, ano,nota));


                            Console.WriteLine("Deseja inserir outro nome ? 1 - SIM | 2 - NÃO");

                            continuar = Console.ReadLine();

                        }


                        break;

                    case 2:
                        Console.WriteLine("Você deseja listar os filmes 1-Sim | 2-Não ");
                        continuar = Console.ReadLine();
                        while (continuar == "1")
                        {


                            foreach (Filme p in filmes)// percorrer na classe filme na instncia filmes

                            {
                                contador = contador + 1;
                                Console.WriteLine("Filme nº : " + contador + " | " + p.Nome + "  ano: " + p.ano + " | Nota : " + p.nota);
                                break;
                            }

                            break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Você deseja remover um filme ? digite a nº do filme  para remoção");
                        int remover = int.Parse(Console.ReadLine());

                        filmes.RemoveAt(remover);
                        break;



                }


                Console.WriteLine("Você deseja realizar nova operação 1 para sim 2 para não");
                voltar = Console.ReadLine();
            } while (voltar == "1");

            var fullPath = @"C:\Users\ReneAndroid.apk\source\repos\ProgramaDio\Filme.txt";
            using (var escritor = new System.IO.StreamWriter(fullPath))
            {
                foreach (Filme p in filmes)
                    escritor.WriteLine(filmes);
            }



        }
    }
}
