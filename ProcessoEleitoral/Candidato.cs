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

        public string TratarDados()
        {
            return id + ";" + nome + ";" + numero + ";" + partido + "@";
        }
    }
}
