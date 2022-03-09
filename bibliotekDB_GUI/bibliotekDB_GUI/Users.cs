using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekDB_GUI
{
    internal class Users : INotifyPropertyChanged
    {
        private int _User_ID;
        public int User_ID { get { return _User_ID; } set { if (_User_ID != value) { _User_ID = value; OnPropertyChanged("User_ID"); } } }
        private string _Login_CPR_No;
        public string Login_CPR_No { get { return _Login_CPR_No; } set { if (_Login_CPR_No != value) { _Login_CPR_No = value; OnPropertyChanged("Login_CPR_No"); } } }
        private string _First_Name;
        public string First_Name { get { return _First_Name; } set { if (_First_Name != value) { _First_Name = value; OnPropertyChanged("First_Name"); } } }
        private string _Last_Name;
        public string Last_Name { get { return _Last_Name; } set { if (_Last_Name != value) { _Last_Name = value; OnPropertyChanged("Last_Name"); } } }
        private string _Email;
        public string Email { get { return _Email; } set { if (_Email != value) { _Email = value; OnPropertyChanged("Email"); } } }
        private string _Adresse;
        public string Adresse { get { return _Adresse; } set { if (_Adresse != value) { _Adresse = value; OnPropertyChanged("Adresse"); } } }
        private string _Phone_No;
        public string Phone_No { get { return _Phone_No; } set { if (value != _Phone_No) { _Phone_No = value; OnPropertyChanged("Phone_No"); } } }
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
