using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    [Serializable]
    public partial class Servico
    {
        public override string ToString()
        {
            return this.DataEntrada.ToShortDateString() + " (tipo:"+this.Tipo+")"+"("+this.Total+ " €)";
        }

        public Decimal Total
        {
            get
            {
                Decimal calculo = 0;

                foreach (Parcela item in this.Parcela)
                {
                    calculo = calculo + item.Valor;

                }
                return calculo;
            }
        }
    }
}
