using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoEleitoral
{
    class Candidato : IControle
    {
        private int id;
        private string nome;
        private int numero;
        private string partido;

        public Candidato(int id, string nome, int numero, string partido)
        {
            this.id = id;
            this.nome = nome;
            this.numero = numero;
            this.partido = partido;
        }
        public Candidato (String a, bool c)
        {
            String[] s;
            if (c)
                s = a.Split(';');
            else
                s = a.Split('-');
            this.id = int.Parse(s[0]);
            this.nome = s[1];
            this.numero = int.Parse(s[2]);
            this.partido = s[3]; 
        }


        public Candidato() { }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Partido
        {
            get { return partido; }
            set { partido = value; }
        }

        public String Mostrar()
        { 
            return id + "-" + nome + "-" + numero + "-" + partido;
        }

        public int PegarID(String s)
        {
            String [] v = s.Split(' ');
            return int.Parse(v[0]); 
        }

        public string TratarDados()
        {
            return id + ";" + nome + ";" + numero + ";" + partido + "@";
        }
    }
}
