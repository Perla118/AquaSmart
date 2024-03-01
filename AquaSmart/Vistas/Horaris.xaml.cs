using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace AquaSmart.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horaris : ContentPage
    {
        public Horaris()
        {
            InitializeComponent();
            GeneratePins();
        }

        private void GeneratePins()
        {
            var pins = new List<Pin>
            {
                new Pin { Type = PinType.Place, Label = "UTS", Address = "UTS", Position = new Position(27.36784668642386, -109.93249298833581) },
                //new Pin { Type = PinType.Place, Label = "Auditorio principal", Address = "UTS", Position = new Position(27.367380221875546, -109.93210668810191) },
            };

            foreach (var pin in pins)
            {
                // Podemos usar FromBundle, FromStream o FromView (custom view)
                //pin.Icon = BitmapDescriptorFactory.FromBundle("planti.png");
                map.Pins.Add(pin);
            }
        }
    }
}