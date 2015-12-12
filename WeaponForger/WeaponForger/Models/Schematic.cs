// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 11/29/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.ComponentModel;

namespace WeaponForger.Models
{
    public class Schematic : INotifyPropertyChanged
    {
        #region Fields

        private int _id;
        private string _name;
        private char[] _slot;

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
        /// Gets or sets the slot.
        /// </summary>
        /// <value>
        /// The slot.
        /// </value>
        public char[] Slot
        {
            get { return _slot; }
            set
            {
                _slot = value;
                OnPropertyChanged("Slot");
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