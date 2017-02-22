using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoEleitoral
{
    class Eleicao : IControle
    {
        private int id;
        private string cargo;
        private string local;
        private int ano;
        private List<Candidato> candidatos = new List<Candidato>();
        private List<int> secoes = new List<int>();

        public Eleicao(int id, string cargo, string local, int ano)
        {
            this.id = id;
            this.cargo = cargo;
            this.local = local;
            this.ano = ano;
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public void AdicionarSecao(string secoes)
        {
            //TODO 
        }

        public string TratarDados()
        {
            return id + ";" + cargo + ";" + local + ";" + ano + "@";
        }
    }
}
