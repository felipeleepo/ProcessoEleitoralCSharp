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
        private string cidade;
        //private int zona;

        public Eleitor(String nome, int titulo, int cpf, string cidade)
        {
            this.nome = nome;
            this.titulo = titulo;
            this.cpf = cpf;
            this.cidade = cidade.ToUpper();
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

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value.ToUpper(); }
        }

        public String TratarDados()
        {
            return "";
        }
    }
}
