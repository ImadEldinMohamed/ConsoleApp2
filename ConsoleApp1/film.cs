using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Film
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set {  nome = value; }

        }

        private string genere;
        public string Genere
        {
            get { return genere; }
            set { genere = value; }
        }

        private int anno;
        public int Anno
        {
            get { return anno; }    
            set { anno = value; }

        }


        public string Nomeanno(string nome,int anno) { 
        return nome+""+anno;}
        

      
     
       

        

       


    }
}
