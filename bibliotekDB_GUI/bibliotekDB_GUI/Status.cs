using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekDB_GUI
{
    internal class Status : INotifyPropertyChanged
    {
        private int _Status_ID;
        public int Status_ID { get { return _Status_ID; } set { if (_Status_ID != value) { _Status_ID = value; OnPropertyChanged("Status_ID"); } } }
        private string _Types_Name;
        public string Types_Name { get { return _Types_Name; } set { if (_Types_Name != value) { _Types_Name = value; OnPropertyChanged("Types_Name"); } } }
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
