using System.ComponentModel;

namespace WeaponForger.Models
{
    public class Schematic : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private char[] _slot;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public char[] Slot
        {
            get { return _slot; }
            set
            {
                _slot = value;
                OnPropertyChanged("Slot");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Name;
        }

        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}