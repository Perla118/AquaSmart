using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaSmart.ViewModels;
using AquaSmart.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AquaSmart.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Areasu : ContentPage
    {
        public Areasu()
        {
            InitializeComponent();
            BindingContext = new VMareas(Navigation);
        }
    }
}