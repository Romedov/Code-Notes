using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp2.Models
{
    public class MainModel : INotifyPropertyChanged
    {
        public MainModel()
        {
            Count1 = 0;
            Count2 = 0;
            Str = "Fock u!";
        }
        private int _c1;
        private int _c2;
        private string _str;
        public int Count1
        {
            get { return _c1; }
            set { _c1 = value; OnPropertyChanged(); }
        }
        public int Count2
        {
            get { return _c2; }
            set { _c2 = value; OnPropertyChanged(); }
        }
        public string Str
        {
            get { return _str; }
            set { _str = value; OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
