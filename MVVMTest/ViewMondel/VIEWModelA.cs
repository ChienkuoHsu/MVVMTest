using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

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
        public string textA
        {
            get { return _a; }
            set
            {
                _a = value;
                NotifyPropertyChanged(nameof(textA));
            }
        }

        public string textB
        {
            get { return _b; }
            set 
            { 
                _b = value;
                NotifyPropertyChanged(nameof(textB));
            }
        }

        
    }
}
