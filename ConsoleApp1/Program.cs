using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Film film1 = new Film();
            film1.Genere = "drammatico";
            film1.Anno = 2020;
            film1.Nome = "Harry-potter";
           Console.WriteLine(film1.Nome);

            Console.WriteLine(film1.Nomeanno("il-re-leone", 1994));
            



            Studente studente1 = new Studente();
            studente1.Nome = "imad";
            studente1.Cognome = "Mohamed";
            Console.WriteLine(studente1.Cognome);
            Console.WriteLine(studente1.NomeCompleto("imad", "Mohamed"));
            



            Dipendente dipendente1 = new Dipendente();
            dipendente1.Preferito = "riposo";
            Console.WriteLine(dipendente1.Preferito);


            Animale animale1 = new Animale();
            animale1.Specie = "leone";
            Console.WriteLine(animale1.Specie);


            Atleta atleta1 = new Atleta();
            atleta1.TipoAtleta = "nuotatore";
            Console.WriteLine(atleta1.TipoAtleta);


            Prodotto prodotto1 = new Prodotto();
            prodotto1.Prezzo = 20;
            prodotto1.Quantità = 10;
            Console.WriteLine(prodotto1.CalcolaTotale(5, 5));

            Console.ReadLine();



        }



      
    }
}
