// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 09/14/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

// Many of the object stored in a weapon must be ignored by the SQL database.
// To avoid having to structure a one-to-many relationship, I created a simple worker around. 

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SQLite;
using WeaponForger.Toolbox;

namespace WeaponForger.Models
{
    public class Weapon : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Weapon"/> class.
        /// </summary>
        public Weapon()
        {
            Id = null;
            Name = "Default Name";
            Materials = new ObservableCollection<Material>();
            Schematic = new Schematic();
            Technique = new Technique();
        }

        #region Fields

        private double _damage;
        private string _materialIds;
        private string _name;
        private Schematic _schematic;
        private int _schematicId;
        private double _speed;
        private Technique _technique;
        private int _techniqueId;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [PrimaryKey]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Gets or sets the speed.
        /// </summary>
        /// <value>
        /// The speed.
        /// </value>
        public double Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                OnPropertyChanged("Speed");
            }
        }

        /// <summary>
        /// Gets or sets the damage.
        /// </summary>
        /// <value>
        /// The damage.
        /// </value>
        public double Damage
        {
            get { return _damage; }
            set
            {
                _damage = value;
                OnPropertyChanged("Damage");
            }
        }

        /// <summary>
        /// Gets or sets the materials.
        /// </summary>
        /// <value>
        /// The materials.
        /// </value>
        [Ignore]
        public ObservableCollection<Material> Materials { get; set; }

        /// <summary>
        /// Gets or sets the material ids.
        /// </summary>
        /// <value>
        /// The material ids.
        /// </value>
        public string MaterialIds
        {
            get { return _materialIds; }
            set
            {
                _materialIds = value;
                OnPropertyChanged("MaterialIds");
            }
        }

        /// <summary>
        /// Gets or sets the technique identifier.
        /// </summary>
        /// <value>
        /// The technique identifier.
        /// </value>
        public int TechniqueId
        {
            get { return _techniqueId; }
            set
            {
                _techniqueId = value;
                OnPropertyChanged("TechniqueId");
            }
        }

        /// <summary>
        /// Gets or sets the schematic identifier.
        /// </summary>
        /// <value>
        /// The schematic identifier.
        /// </value>
        public int SchematicId
        {
            get { return _schematicId; }
            set
            {
                _schematicId = value;
                OnPropertyChanged("SchematicId");
            }
        }

        /// <summary>
        /// Gets or sets the schematic.
        /// </summary>
        /// <value>
        /// The schematic.
        /// </value>
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

        /// <summary>
        /// Gets or sets the technique.
        /// </summary>
        /// <value>
        /// The technique.
        /// </value>
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

        /// <summary>
        /// Occurs when [property changed].
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Generates the weapon.
        /// </summary>
        public void GenerateWeapon()
        {
            var gen = new NameGenerator(this);
            Name = gen.Generate();

            var materialIds = "";

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

                materialIds += material.Id + ",";
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

            MaterialIds = materialIds;
        }

        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="name">The name.</param>
        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        #endregion

    }
}