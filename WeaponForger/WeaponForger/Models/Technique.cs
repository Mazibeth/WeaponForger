using System.ComponentModel;
using WeaponForger.Enums;

namespace WeaponForger.Models
{
    public class Technique : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private MaterialType _primary;
        private MaterialType _secondary;
        private MaterialType _tertiary;

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

        public MaterialType Primary
        {
            get { return _primary; }
            set
            {
                _primary = value;
                OnPropertyChanged("Primary");
            }
        }

        public MaterialType Secondary
        {
            get { return _secondary; }
            set
            {
                _secondary = value;
                OnPropertyChanged("Secondary");
            }
        }

        public MaterialType Tertiary
        {
            get { return _tertiary; }
            set
            {
                _tertiary = value;
                OnPropertyChanged("Tertiary");
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