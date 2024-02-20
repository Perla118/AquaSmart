using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using AquaSmart.Vistas;
using System.Threading.Tasks;

namespace AquaSmart.ViewModels
{
    public class VMareas : BaseViewModel
    {
        #region VARIABLES

        #endregion

        #region CONSTRUCTOR
        public VMareas(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion

        #region OBJETOS

        #endregion

        #region PROCESOS
        public async Task Menu()
        {
            await Navigation.PushAsync(new ConfArea());
        }
        public async Task Areas()
        {
            await Navigation.PushAsync(new Areasu());
        }
        #endregion
        #region COMANDOS
        public ICommand Confcommand => new Command(async () => await Menu());
        public ICommand Areasco => new Command(async () => await Areas());

        #endregion
    }
}
