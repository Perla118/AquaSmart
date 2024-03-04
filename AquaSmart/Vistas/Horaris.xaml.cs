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

            // CONFIGURAR EL COMIENZO EN STREET POR DEFAULT
            MapView.MapType = MapType.Street;

            // AAGREGAMOS LOS PINS PARA AL INICIAR 
            Limpiar_AñadirPins();

            MapView.MoveToRegion(
            MapSpan.FromCenterAndRadius(
            new Position(27.366736, -109.931755), Distance.FromMiles(1)));
        }

        private void Street_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Street;
            Limpiar_AñadirPins();
        }
        private void Hybrid_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Hybrid;
            Limpiar_AñadirPins();

        }
        private void Satellite_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Satellite;
            LimpiarPins();
        }
        // AGREGANDO LOS PINS
        private void Limpiar_AñadirPins()
        {
            LimpiarPins();
            var streetPins = new List<Pin>
    {
                new Pin {
                    Type = PinType.Place,
                    Label = "Jardin entrada Principal",
                    Address = "Zona B",
                    Position = new Position(27.36784668642386, -109.93249298833581),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ceespedd.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "ceespedd.png", WidthRequest = 164, HeightRequest = 160 }),
        },
                new Pin {
                    Type = PinType.Place,
                    Label = "Edificio 1",
                    Address = "UTS",
                    Position = new Position(27.366948, -109.932045),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("edificioo.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "edificioo.png", WidthRequest = 160, HeightRequest = 160 }),
                },
                new Pin {
                    Type = PinType.Place,
                    Label = "Edificio 2",
                    Address = "UTS",
                    Position = new Position(27.366638, -109.931343),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("edificioo.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "edificioo.png", WidthRequest = 160, HeightRequest = 160 }),
                },
                new Pin {
                    Type = PinType.Place,
                    Label = "Edificio 4",
                    Address = "UTS",
                    Position = new Position(27.365786, -109.931359),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("edificioo.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "edificioo.png", WidthRequest = 160, HeightRequest = 160 }),
                },
                new Pin {
                    Type = PinType.Place,
                    Label = "Biblioteca Universitaria",
                    Address = "UTS",
                    Position = new Position(27.366376, -109.932131),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("libros.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "libros.png", WidthRequest = 160, HeightRequest = 160 }),
                },
                new Pin {
                    Type = PinType.Place,
                    Label = "Cafeteria",
                    Address = "UTS",
                    Position = new Position(27.367776, -109.931075),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("cafe.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "cafe.png", WidthRequest = 160, HeightRequest = 160 }),
                },
                new Pin {
                    Type = PinType.Place,
                    Label = "Jardin Edificio 2",
                    Address = "Zona B",
                    Position = new Position(27.366480, -109.931363),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ceespedd.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "ceespedd.png", WidthRequest = 160, HeightRequest = 160 }),
                },
                new Pin {
                    Type = PinType.Place,
                    Label = "Jardin Biblioteca",
                    Address = "Zona C",
                    Position = new Position(27.366226, -109.931896),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ceespedd.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "ceespedd.png", WidthRequest = 160, HeightRequest = 160 }),
                },
                new Pin {
                    Type = PinType.Place,
                    Label = "Jardin Central",
                    Address = "Zona D",
                    Position = new Position(27.367153, -109.931896),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ceespedd.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "ceespedd.png", WidthRequest = 160, HeightRequest = 160 }),
                },
                new Pin {
                    Type = PinType.Place,
                    Label = "Jardin CDS",
                    Address = "Zona E",
                    Position = new Position(27.367319, -109.931323),
                    Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ceespedd.png") :
                    BitmapDescriptorFactory.FromView(new Image() { Source = "ceespedd.png", WidthRequest = 160, HeightRequest = 160 }),
                 }
    };
            foreach (var pin in streetPins)
            {
                MapView.Pins.Add(pin);
            }
        }
        //LIMPIAR LOS PINESS
        private void LimpiarPins()
        {
            MapView.Pins.Clear();
        }
    }
}