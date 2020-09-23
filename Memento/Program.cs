using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Diego", TipoContrato.NOVO);
            historico.adiciona(contrato.salvaEstado());

            contrato.avanca();
            historico.adiciona(contrato.salvaEstado());

            contrato.avanca();
            historico.adiciona(contrato.salvaEstado());

            contrato.avanca();
            historico.adiciona(contrato.salvaEstado());

            contrato.printAtributos();

            contrato.restaura(historico.pega(0));

            contrato.printAtributos();

            Console.ReadLine();
        }
    }
}
