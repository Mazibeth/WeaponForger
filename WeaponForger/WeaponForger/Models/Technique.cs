// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 11/25/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.ComponentModel;
using WeaponForger.Enums;

namespace WeaponForger.Models
{
    public class Technique : INotifyPropertyChanged
    {
        #region Fields

        private int _id;
        private string _name;
        private MaterialType _primary;
        private MaterialType _secondary;
        private MaterialType _tertiary;

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
        /// Gets or sets the primary.
        /// </summary>
        /// <value>
        /// The primary.
        /// </value>
        public MaterialType Primary
        {
            get { return _primary; }
            set
            {
                _primary = value;
                OnPropertyChanged("Primary");
            }
        }

        /// <summary>
        /// Gets or sets the secondary.
        /// </summary>
        /// <value>
        /// The secondary.
        /// </value>
        public MaterialType Secondary
        {
            get { return _secondary; }
            set
            {
                _secondary = value;
                OnPropertyChanged("Secondary");
            }
        }

        /// <summary>
        /// Gets or sets the tertiary.
        /// </summary>
        /// <value>
        /// The tertiary.
        /// </value>
        public MaterialType Tertiary
        {
            get { return _tertiary; }
            set
            {
                _tertiary = value;
                OnPropertyChanged("Tertiary");
            }
        }

        /// <summary>
        /// Occurs when [property changed].
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods


        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Name;
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