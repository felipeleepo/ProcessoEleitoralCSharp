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

        public Eleicao(string cargo, string local, int ano, Candidato candidato)
        {
            this.cargo = cargo;
            this.local = local;
            this.ano = ano;
            candidatos.Add(candidato);
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

        public void AdicionarSecao(string secoes)
        {
            //TODO 
        }

        public string TratarDados()
        {
            throw new NotImplementedException();
        }
    }
}
