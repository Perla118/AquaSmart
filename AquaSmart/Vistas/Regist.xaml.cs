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
    public partial class Regist : ContentPage
    {
        public Regist()
        {
            InitializeComponent();
            BindingContext = new VMregistro(Navigation);
        }
    }
}