using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nalga2Test
{
    class Višina
    {
        public int _M;
        public int _cm;
        public int _mm;

        public int M {
            get { return _M; }
            set { _M = value; }

        }
        public int CM {
            get { return _cm; }
            set { _cm = value; }

        }
        public int MM{
            get { return _mm; }
            set { _mm = value; }


}
    
        public void Dodaj(int mm)
        {
            int temp_m = mm / 1000;
            int temp_cm = (mm % 1000) /10;
            int temp_mm = (mm % 10) /10;
            
            this.M = this.M + temp_m;
            this.CM = this.CM + temp_cm;   
            this.MM = this.MM + temp_mm;


        }
    public override string ToString()
        {

            return this.M + "M " + this.CM + "CM " + this.MM;

        }
    
    
    }

}
