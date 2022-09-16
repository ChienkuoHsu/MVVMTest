using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest
{
    internal class mainClass
    {
        public VIEWModelA va { get; set; }
        public VIEWModelB vb { get; set; }
        public mainClass()
        {
            va = new VIEWModelA();
            vb = new VIEWModelB();
            va.PropertyChanged += (o, p) =>
           {
               vb.setText("A:" + va.textA + "B:" + va.textB);
           };
        }

    }
}
