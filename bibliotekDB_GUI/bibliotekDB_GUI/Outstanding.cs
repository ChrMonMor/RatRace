using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekDB_GUI
{
    internal class Outstanding : INotifyPropertyChanged
    {
        private int _Outstandings_ID;
        public int Outstandings_ID { get { return _Outstandings_ID; } set { if (_Outstandings_ID != value) { _Outstandings_ID = value; OnPropertyChanged("Outstandings_ID"); } } }
        private int _Users_User_ID;
        public int Users_User_ID { get { return _Users_User_ID; } set { if (_Users_User_ID != value) { _Users_User_ID = value; OnPropertyChanged("Users_User_ID"); } } }
        private int _Amount;
        public int Amount { get { return _Amount; } set { if (_Amount != value) { _Amount = value; OnPropertyChanged("Amount"); } } }
        private DateTime _Till_Date;
        public DateTime Till_Date { get { return _Till_Date; } set { if (_Till_Date != value) { _Till_Date = value; OnPropertyChanged("Till_Date"); } } }
        private DateTime _From_Date;
        public DateTime From_Date { get { return _From_Date; } set { if (_From_Date != value) { _From_Date = value; OnPropertyChanged("From_Date"); } } }
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
