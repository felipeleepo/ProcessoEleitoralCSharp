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
        private int zona;
        private int secao;

        public Eleitor(int id, String nome, int titulo, int cpf, int zona, int secao)
        {
            this.id = id;
            this.nome = nome;
            this.titulo = titulo;
            this.cpf = cpf;
            this.zona = zona;
            this.secao = secao;
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

        public int Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public int Secao
        {
            get { return secao; }
            set { secao = value; }
        }

        public String TratarDados()
        {
            return id + ";" + nome + ";" + titulo + ";" + cpf + ";" + zona + ";" + secao + "@";
        }
    }
}
