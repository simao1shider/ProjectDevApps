using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class CarroVenda : Carro
    {
        public override string ToString()
        {
            return this.Marca + " (" + this.Modelo + ")";
        }
    }
}
