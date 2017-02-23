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

        public Eleicao() { }
        public Eleicao (String a)
        {
            String[] s = a.Split(';');
            this.id = int.Parse(s[0]);
            this.cargo = s[1];
            this.local = s[2];
            this.ano = int.Parse(s[3]);
        }
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

        public int getId()
        {
            return id;
        }

        public List<Candidato> getListCandidato()
        {
            return candidatos;
        }
       public String MostrarCandidatos(int i)
        {
            return candidatos[i].Mostrar();
        }

        public int PegarID(String s)
        {
            String[] v = s.Split(' ');
            return int.Parse(v[0]);
        }

        public String Mostrar()
        {
            return id + "-" + cargo + "-" + local + "-" + ano;
        }

        public string TratarDados()
        {
            return id + ";" + cargo + ";" + local + ";" + ano + "@";
        }

        public void AdicionarCandidato(Candidato c)
        {
            candidatos.Add(c);
        }
    }
}
