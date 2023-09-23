using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2_ariketa_matematikoa_
{
    internal class Ariketa
    {
        public float zenb1 { get; set; }
        public float zenb2 { get; set; }
        public float zenb3 { get; set; }
        public float zenb4 { get; set; }

        public float eragiketa { get; set; }

        public float eragiketaluzea()
        {
            return eragiketa += (this.zenb1 + 2 * this.zenb2 + 3 * this.zenb3 + 4 * this.zenb4) / 4;

        }
    }
}
