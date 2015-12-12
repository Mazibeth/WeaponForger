using System.ComponentModel;
using WeaponForger.Enums;

namespace WeaponForger.Models
{
    public class Material : INotifyPropertyChanged
    {
        private double _hardness;
        private int _id;
        private string _name;
        private double _resistance;
        private MaterialType _type;
        private double _weight;

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

        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        public double Hardness
        {
            get { return _hardness; }
            set
            {
                _hardness = value;
                OnPropertyChanged("Hardness");
            }
        }

        public double Resistance
        {
            get { return _resistance; }
            set
            {
                _resistance = value;
                OnPropertyChanged("Resistance");
            }
        }

        public MaterialType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Clone(Material material)
        {
            Id = material.Id;
            Name = material.Name;
            Type = material.Type;
            Weight = material.Weight;
            Hardness = material.Hardness;
            Resistance = material.Resistance;
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