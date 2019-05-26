using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class ClassCliente
    {

        public String nome, morada;
        public int NIF, contacto;

        public ClassCliente(string Nome, int NIF, string Morada, int Contacto)
        {
            this.nome = Nome;
            this.NIF = NIF;
            this.morada = Morada;
            this.contacto = Contacto;
        }

        public override string ToString()
        {
            return this.nome + " (" +this.NIF+ ")";
        }
    }
}
