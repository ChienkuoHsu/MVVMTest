using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVMTest
{

    internal class VIEWModelB
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private string _testb { get; set; }
        public string testB
        {
            get
            {
                return _testb;
            }
            set
            {
                _testb = value;
                NotifyPropertyChanged(nameof(testB));
            }
        }

        public VIEWModelB()
        {
            setText("This is B");
        }

        public void setText(string s)
        {
            testB = s;
        }
    }


}
