using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarKezeloRendszer
{
    class Raktarhely
    {
        public string RaktarhelyNeve { get; set; }
        public string RaktarhelyTipusa { get; set; }

        public Raktarhely(string raktarhelyNeve, string raktarhelyTipusa)
        {
            RaktarhelyNeve = raktarhelyNeve;
            RaktarhelyTipusa = raktarhelyTipusa;
        }

        public Raktarhely(string raktarhelyNeve)
        {
            RaktarhelyNeve = raktarhelyNeve;
        }

        public override string ToString()
        {
            return $"{RaktarhelyNeve}, {RaktarhelyTipusa}";
        }
    }
}
