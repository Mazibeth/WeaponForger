using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SQLite;
using WeaponForger.Toolbox;

namespace WeaponForger.Models
{
    public class Weapon : INotifyPropertyChanged
    {
        private double _damage;
        private string _materialIds;
        private string _name;
        private Schematic _schematic;
        private int _schematicId;
        private double _speed;
        private Technique _technique;
        private int _techniqueId;

        public Weapon()
        {
            Id = null;
            Name = "Default Name";
            Materials = new ObservableCollection<Material>();
            Schematic = new Schematic();
            Technique = new Technique();
        }

        [PrimaryKey]
        public int? Id { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public double Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                OnPropertyChanged("Speed");
            }
        }

        public double Damage
        {
            get { return _damage; }
            set
            {
                _damage = value;
                OnPropertyChanged("Damage");
            }
        }

        [Ignore]
        public ObservableCollection<Material> Materials { get; set; }

        public string MaterialIds
        {
            get { return _materialIds; }
            set
            {
                _materialIds = value;
                OnPropertyChanged("MaterialIds");
            }
        }

        public int TechniqueId
        {
            get { return _techniqueId; }
            set
            {
                _techniqueId = value;
                OnPropertyChanged("TechniqueId");
            }
        }

        public int SchematicId
        {
            get { return _schematicId; }
            set
            {
                _schematicId = value;
                OnPropertyChanged("SchematicId");
            }
        }

        [Ignore]
        public Schematic Schematic
        {
            get { return _schematic; }
            set
            {
                _schematic = value;
                SchematicId = value.Id;
                OnPropertyChanged("Schematic");
            }
        }

        [Ignore]
        public Technique Technique
        {
            get { return _technique; }
            set
            {
                _technique = value;
                TechniqueId = value.Id;
                OnPropertyChanged("Technique");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GenerateWeapon()
        {
            var gen = new NameGenerator(this);
            Name = gen.Generate();

            Damage = 0;
            Speed = 0;

            foreach (var material in Materials)
            {
                Damage += material.Weight;
                Damage += material.Hardness;
                Damage -= material.Resistance;

                Speed += material.Resistance;
                Speed += material.Hardness;
                Speed -= material.Weight;

                MaterialIds += material.Id + ",";
            }

            Damage = Math.Round(Damage / Materials.Count, 1);
            Speed = Math.Round(Speed / Materials.Count, 1);

            if (Damage < 1)
            {
                Damage = 1;
            }
            if (Speed < 1)
            {
                Speed = 1;
            }
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