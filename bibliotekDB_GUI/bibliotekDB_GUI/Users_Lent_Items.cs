using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekDB_GUI
{
    internal class Users_Lent_Items : INotifyPropertyChanged
    {
        private int _Users_Lent_Items_ID;
        public int Users_Lent_Items_ID { get { return _Users_Lent_Items_ID; } set { if (_Users_Lent_Items_ID != value) { _Users_Lent_Items_ID = value; OnPropertyChanged("Users_Lent_Items_ID"); } } }
        private int _Users_User_ID;
        public int Users_User_ID { get { return _Users_User_ID; } set { if (_Users_User_ID != value) { _Users_User_ID = value; OnPropertyChanged("Users_User_ID"); } } }
        private int _Items_Item_ID;
        public int Items_Item_ID { get { return _Items_Item_ID; } set { if (_Items_Item_ID != value) { _Items_Item_ID = value; OnPropertyChanged("Items_Item_ID"); } } }
        private DateTime _Return_Date;
        public DateTime Return_Date { get { return _Return_Date; } set { if (_Return_Date != value) { _Return_Date = value; OnPropertyChanged("Return_Date"); } } }
        private int _Return_renewal;
        public int Return_renewal { get { return _Return_renewal; } set { if (_Return_renewal != value) { _Return_renewal = value; OnPropertyChanged("Return_renewal"); } } }
        private int _Returned;
        public int Returned { get { return _Returned; } set { if (_Returned != value) { _Returned = value; OnPropertyChanged("Returned"); } } }
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
