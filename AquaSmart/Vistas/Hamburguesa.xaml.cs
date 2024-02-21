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
    public partial class Hamburguesa : MasterDetailPage
    {
        public Hamburguesa()
        {
            InitializeComponent();
            BindingContext = new VMburger(Navigation);
            Elmenu();
        }

        public void Elmenu()
        {
            Detail = new NavigationPage(new Reports());
            List<Menu> menu = new List<Menu>
            {
                //new Menu{ Pagina= new Inicio(),Nombre="Inicio", Icono="https://i.ibb.co/M7y1WLh/casita.png"},
                new Menu{ Pagina= new Reports (),Nombre="Reportes", Icono="https://i.ibb.co/TrNjZyY/estadisticas.png"},
                new Menu{ Pagina= new Areasu(),Nombre="Áreas", Icono="https://i.ibb.co/d600tff/hierba.png",},
                new Menu{ Pagina= new Horaris(),Nombre="Horarios", Icono="https://i.ibb.co/52WBW5t/despertador.png"},
            };
            ListMenu.ItemsSource = menu;
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Pagina);
            }
        }
        public class Menu
        {
            public string Nombre
            {
                get;
                set;
            }

            public ImageSource Icono
            {
                get;
                set;
            }

            public Page Pagina
            {
                get;
                set;
            }
        }
    }
}