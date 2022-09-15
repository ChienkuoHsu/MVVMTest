using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVMTest
{
    public class VIEWModelA : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        

        private void NotifyPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _a;
        private string _b;
        public string testA
        {
            get { return _a; }
            set
            {
                _a = value;
                B = value;
                NotifyPropertyChanged();
            }
        }
        public string B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }


        public VIEWModelA()
        {
            testA = "Test";
        }

        
    }
}
