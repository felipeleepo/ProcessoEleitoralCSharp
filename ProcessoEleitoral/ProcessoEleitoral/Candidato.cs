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
        private string cargo;

        public Candidato(string nome, int numero, string partido, string cargo)
        {
            this.nome = nome;
            this.numero = numero;
            this.partido = partido;
            this.cargo = cargo.ToUpper();
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
            throw new NotImplementedException();
        }
    }
}
