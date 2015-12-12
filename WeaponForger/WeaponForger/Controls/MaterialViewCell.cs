using Xamarin.Forms;

namespace WeaponForger.Controls
{
    public class MaterialViewCell : ViewCell
    {
        public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof (string),
            typeof (MaterialViewCell), "");

        public string Name
        {
            get { return (string) GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
    }
}