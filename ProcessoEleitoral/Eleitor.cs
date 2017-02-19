using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoEleitoral
{
    class Eleitor : IControle
    {
        private String nome;
        private int titulo;
        private int cpf;

        public String TratarDados()
        {
            return nome + ";" + titulo + "@";
        }

        public Eleitor(String nome, int titulo)
        {
            this.nome = nome;
            this.titulo = titulo;
        }
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }
    }
}
