using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2.ViewModels
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            mainModel = new MainModel();
        }
        public MainModel mainModel { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public int Count1
        {
            get { return mainModel.Count1; }
            set
            {
                mainModel.Count1 = value;
                OnPropertyChanged();
            }
        }
        public int Count2
        {
            get { return mainModel.Count2; }
            set
            {
                mainModel.Count2 = value;
                OnPropertyChanged();
            }
        }
        public string Str
        {
            get { return mainModel.Str; }
            set { mainModel.Str = value; OnPropertyChanged(); }
        }
        public ICommand Cmd1
        {
            get
            {
                return new DelegadeCommand((obj) =>
                {
                    Count1++;
                });
            }
        }
        public ICommand Cmd2
        {
            get
            {
                return new DelegadeCommand((obj) =>
                {
                    Count2++;
                });
            }
        }
        public ICommand Cmd3
        {
            get
            {
                return new DelegadeCommand((obj) =>
                {
                    PasswordBox passwordBox = obj as PasswordBox;
                    MessageBox.Show(passwordBox.SecurePassword.ToString());
                });
            }
        }
    }
}
