// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 09/14/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.ComponentModel;
using WeaponForger.Enums;

namespace WeaponForger.Models
{
    public class Material : INotifyPropertyChanged
    {
        #region Fields

        private double _hardness;
        private int _id;
        private string _name;
        private double _resistance;
        private MaterialType _type;
        private double _weight;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

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
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        /// <summary>
        /// Gets or sets the hardness.
        /// </summary>
        /// <value>
        /// The hardness.
        /// </value>
        public double Hardness
        {
            get { return _hardness; }
            set
            {
                _hardness = value;
                OnPropertyChanged("Hardness");
            }
        }

        /// <summary>
        /// Gets or sets the resistance.
        /// </summary>
        /// <value>
        /// The resistance.
        /// </value>
        public double Resistance
        {
            get { return _resistance; }
            set
            {
                _resistance = value;
                OnPropertyChanged("Resistance");
            }
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public MaterialType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Occurs when [property changed].
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Clones the specified material.
        /// </summary>
        /// <param name="material">The material.</param>
        public void Clone(Material material)
        {
            Id = material.Id;
            Name = material.Name;
            Type = material.Type;
            Weight = material.Weight;
            Hardness = material.Hardness;
            Resistance = material.Resistance;
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