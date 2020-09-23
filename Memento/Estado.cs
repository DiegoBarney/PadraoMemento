using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Estado
    {

        private Contrato contrato;

        public Estado(Contrato contrato)
        {
            this.contrato = contrato;
        }


        public Contrato getContrato()
        {
            return contrato;
        }

    }
}
