using AquaSmart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AquaSmart.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfArea : ContentPage
    {
        public ConfArea()
        {
            InitializeComponent();
            BindingContext = new VMareas(Navigation);
        }
    }
}