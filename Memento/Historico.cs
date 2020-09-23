using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Historico
    {
        private List<Estado> estadosSalvos = new List<Estado>();

        public Estado pega(int index)
        {
            return estadosSalvos[index];
        }

        public void adiciona(Estado estado)
        {
            estadosSalvos.Add(estado);
        }
    }
}
