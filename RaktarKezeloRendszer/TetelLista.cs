using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarKezeloRendszer
{
    class TetelLista
    {
        public List<Tetel> tetelLista { get; set; }

        public TetelLista(List<Tetel> tetelLista)
        {
            this.tetelLista = new List<Tetel>();
        }
    }
}
