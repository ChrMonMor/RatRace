using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekDB_GUI
{
    internal class Login : INotifyPropertyChanged
    {
        private int _CPR_No;
        public int CPR_No { get { return _CPR_No; } set { if (_CPR_No != value) { _CPR_No = value; OnPropertyChanged("CPR_No"); } } }
        private string _Password;
        public string Password { get { return _Password; } set { if (_Password != value) { _Password = value; OnPropertyChanged("Password"); } } }
        public virtual void RaisePropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
