using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OinarrizkoKalkulagailua
{
    internal class Kalkulagailua
    {
        //propietateak
        public float Zenbakia1 { get; set; }
        public float Zenbakia2 { get; set; }
        
        //konstruktoreak
        public Kalkulagailua() { }
        public Kalkulagailua(float zenbakia1, float zenbakia2) 
        { 
            this.Zenbakia1 = zenbakia1;
            this.Zenbakia2 = zenbakia2;
        }
        //metodoak
        public float Gehiketa() 
        {
            return Zenbakia1 + Zenbakia2;
        }
        public float Kenketa()
        {
            return Zenbakia1 - Zenbakia2;
        }
        public float Biderketa()
        {
            return Zenbakia1 * Zenbakia2;
        }
        public float Zatiketa()
        {
            return Zenbakia1 / Zenbakia2;

        }
    }
}
