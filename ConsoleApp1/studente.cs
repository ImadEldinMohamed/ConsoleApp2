using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Studente
    {

        private string nome;
        public string Nome
        {
            get { return nome; }    
            set { nome = value; }
        }

        public string Cognome { get; set; }



        public string Preferito { get; set; }


        public string NomeCompleto(string nome,string cognome) { return nome + cognome; }
    }

        
}
