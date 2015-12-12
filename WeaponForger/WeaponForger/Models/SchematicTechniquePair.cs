using System.ComponentModel;
using System.Linq;
using WeaponForger.Data;

namespace WeaponForger.Models
{
    public class SchematicTechniquePair
    {
        private Schematic _schematic;
        private string _schematicName;
        private Technique _technique;
        private string _techniqueName;

        public SchematicTechniquePair()
        {
            SchematicLibrary = new SchematicLibrary();
            TechniqueLibrary = new TechniqueLibrary();
        }

        public SchematicLibrary SchematicLibrary { get; set; }
        public TechniqueLibrary TechniqueLibrary { get; set; }

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

        public Schematic Schematic
        {
            get { return _schematic; }
            set
            {
                _schematic = value;
                OnPropertyChanged("Schematic");
            }
        }

        public Technique Technique
        {
            get { return _technique; }
            set
            {
                _technique = value;
                OnPropertyChanged("Technique");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

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