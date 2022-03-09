using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekDB_GUI
{
    internal class Users_Reseved_Items : INotifyPropertyChanged
    {
        private int _Users_Reseved_Items_ID;
        public int Users_Reseved_Items_ID { get { return _Users_Reseved_Items_ID; } set { if (_Users_Reseved_Items_ID != value) { _Users_Reseved_Items_ID = value; OnPropertyChanged("Users_Reseved_Items_ID"); } } }
        private int _Items_Item_ID;
        public int Items_Item_ID { get { return _Items_Item_ID; } set { if (_Items_Item_ID != value) { _Items_Item_ID = value; OnPropertyChanged("Items_Item_ID"); } } }
        private int _Users_User_ID;
        public int Users_User_ID { get { return _Users_User_ID; } set { if (_Users_User_ID != value) { _Users_User_ID = value; OnPropertyChanged("Users_User_ID"); } } }
        private DateTime _Reserved_Date;
        public DateTime Reserved_Date { get { return _Reserved_Date; } set { if (_Reserved_Date != value) { _Reserved_Date = value; OnPropertyChanged("Reserved_Date"); } } }
        private DateTime _Waiting_Till;
        public DateTime Waiting_Till { get { return _Waiting_Till; } set { if (_Waiting_Till != value) { _Waiting_Till = value; OnPropertyChanged("Waiting_Till"); } } }
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
