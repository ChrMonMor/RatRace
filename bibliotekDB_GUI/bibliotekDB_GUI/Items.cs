using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekDB_GUI
{
    internal class Items : INotifyPropertyChanged
    {
        private int _Items_ID;
        public int Items_ID { get { return _Items_ID; } set { if (_Items_ID != value) { _Items_ID = value; OnPropertyChanged("Items_ID"); } } }
        private int _Media_Types_ID;
        public int Media_Types_ID { get { return (int)_Media_Types_ID; } set { if (_Media_Types_ID != value) { _Media_Types_ID = value; OnPropertyChanged("Media_Types_ID"); } } }
        private int _Statue_Statue_ID;
        public int Statue_Statue_ID { get { return (int)_Statue_Statue_ID; } set { if (_Statue_Statue_ID != value) { _Statue_Statue_ID = value; OnPropertyChanged("Statue_Statue_ID"); } } }
        private string _Isbn_No;
        public string Isbn_No { get { return _Isbn_No; } set { if (_Isbn_No != value) { _Isbn_No = value; OnPropertyChanged("Isbn_No"); } } }
        private string _DK5_No;
        public string DK5_No { get { return _DK5_No; } set { if (_DK5_No != value) { _DK5_No = value; OnPropertyChanged("DK5_No"); } } }
        private string _Titel;
        public string Titel { get { return _Titel; } set { if (_Titel != value) { _Titel = value; OnPropertyChanged("Titel"); } } }
        private string _Description;
        public string Description { get { return _Description; } set { if(value != _Description) { _Description = value; OnPropertyChanged("Description"); } } }
        private string _Author;
        public string Author { get { return _Author; }  set { if(value != _Author) { _Author = value; OnPropertyChanged("Author");} } }
        private string _Publisher;
        public string Publisher { get { return _Publisher; } set { if (value != _Publisher) { _Publisher = value; OnPropertyChanged("Publisher"); } }}
        private int _Lent_time;
        public int Lent_time { get { return _Lent_time; } set { if (value != _Lent_time) { _Lent_time = value; OnPropertyChanged("Lent_time"); } } }
        private string _Osv;
        public string Osv { get { return _Osv; } set { if(value != _Osv) { _Osv = value; OnPropertyChanged("Osv"); } } }

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
