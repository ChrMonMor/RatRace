using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekDB_GUI
{
    internal class Media : INotifyPropertyChanged
    {
        private int _Types_ID;
        public int Types_ID { get { return _Types_ID; } set { if (_Types_ID != value) { _Types_ID = value; OnPropertyChanged("Types_ID"); } } }
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
