// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/03/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.ComponentModel;
using System.Linq;
using WeaponForger.Data;

namespace WeaponForger.Models
{
    public class SchematicTechniquePair
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchematicTechniquePair"/> class.
        /// </summary>
        public SchematicTechniquePair()
        {
            SchematicLibrary = new SchematicLibrary();
            TechniqueLibrary = new TechniqueLibrary();
        }

        #region Fields

        private Schematic _schematic;
        private string _schematicName;
        private Technique _technique;
        private string _techniqueName;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the schematic library.
        /// </summary>
        /// <value>
        /// The schematic library.
        /// </value>
        public SchematicLibrary SchematicLibrary { get; set; }
        /// <summary>
        /// Gets or sets the technique library.
        /// </summary>
        /// <value>
        /// The technique library.
        /// </value>
        public TechniqueLibrary TechniqueLibrary { get; set; }

        /// <summary>
        /// Gets or sets the name of the schematic.
        /// </summary>
        /// <value>
        /// The name of the schematic.
        /// </value>
        public string SchematicName
        {
            get { return _schematicName; }
            set
            {
                _schematicName = value;
                OnPropertyChanged("SchematicName");
                Schematic = SchematicLibrary.Schematics.First(x => x.Name == SchematicName);
            }
        }

        /// <summary>
        /// Gets or sets the name of the technique.
        /// </summary>
        /// <value>
        /// The name of the technique.
        /// </value>
        public string TechniqueName
        {
            get { return _techniqueName; }
            set
            {
                _techniqueName = value;
                OnPropertyChanged("TechniqueName");
                Technique = TechniqueLibrary.Techniques.First(x => x.Name == TechniqueName);
            }
        }

        /// <summary>
        /// Gets or sets the schematic.
        /// </summary>
        /// <value>
        /// The schematic.
        /// </value>
        public Schematic Schematic
        {
            get { return _schematic; }
            set
            {
                _schematic = value;
                OnPropertyChanged("Schematic");
            }
        }

        /// <summary>
        /// Gets or sets the technique.
        /// </summary>
        /// <value>
        /// The technique.
        /// </value>
        public Technique Technique
        {
            get { return _technique; }
            set
            {
                _technique = value;
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