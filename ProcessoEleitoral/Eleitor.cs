using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoEleitoral
{
    class Eleitor : IControle
    {
        private int id;
        private String nome;
        private int titulo;
        private int cpf;
        private string local;

        public Eleitor(int id, String nome, int titulo, int cpf, string local)
        {
            this.id = id;
            this.nome = nome;
            this.titulo = titulo;
            this.cpf = cpf;
            this.local = local;
        }

        public Eleitor (String a)
        {
            String[] s = a.Split(';');
            this.id = int.Parse(s[0]);
            this.nome = s[1];
            this.titulo = int.Parse(s[2]);
            this.cpf = int.Parse(s[3]);
            this.local = s[4];
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

       

        public String TratarDados()
        {
            return id + ";" + nome + ";" + titulo + ";" + cpf + ";" + local + "@";
        }
    }
}
