using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarKezeloRendszer
{
    class Beszallito
    {
        public string BeszallitoNeve { get; set; }
        public string BeszallitotttermekTipusa {get; set; }

        public Beszallito(string beszallitoNeve, string beszallitotttermekTipusa)
        {
            BeszallitoNeve = beszallitoNeve;
            BeszallitotttermekTipusa = beszallitotttermekTipusa;
        }
    }
}
