using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Class1
    {
        string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        int yas;
        public int Yas
        {
            get { return yas - 5; }
            set { yas = value; }
        }
        int not1;
        public int Not1
        {
            set { not1 = value; }
        }
        int not2;
        public int Not2
        {
            set { not2 = value; }
        }
        int ort;
        public int Ort
        {
            get {
                ort = (not1 + not2) / 2;
                return ort; }
        }
        public override string ToString()
        {
            return ad + "-" + yas + "ortalaması" + ort;
        }
    }
}
