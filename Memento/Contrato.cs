using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Contrato
    {
        private DateTime data;
        private String cliente;
        private TipoContrato tipo;

        public Contrato(DateTime data, String cliente, TipoContrato tipo)
        {
            this.data = data;
            this.cliente = cliente;
            this.tipo = tipo;
        }

        // getters e setters

        public void avanca()
        {
            if (tipo == TipoContrato.NOVO) tipo = TipoContrato.EM_ANDAMENTO;
            else if (tipo == TipoContrato.EM_ANDAMENTO) tipo = TipoContrato.ACERTADO;
            else if (tipo == TipoContrato.ACERTADO) tipo = TipoContrato.CONCLUIDO;
        }

        public Estado salvaEstado()
        {
            return new Estado(new Contrato(data, cliente, tipo));
        }

        public void restaura(Estado estado)
        {
            this.data = estado.getContrato().data;
            this.cliente = estado.getContrato().cliente;
            this.tipo = estado.getContrato().tipo;
        }

        public void printAtributos() {
            Console.WriteLine(data);
            Console.WriteLine(cliente);
            Console.WriteLine(tipo);
        }
    }
}
