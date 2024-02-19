using AquaSmart.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AquaSmart.ViewModels
{
    public class VMregistro : BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONTRUCTOR
        public VMregistro(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS

        #endregion
        #region PROCESOS
        public async Task Login()
        {
            await Navigation.PushAsync(new Login());
        }
        public async Task IraLogin()
        {
            await Navigation.PushAsync(new Login());
        }

        #endregion
        #region COMANDOS
        public ICommand Loginu => new Command(async () => await Login());
        public ICommand Logind => new Command(async () => await IraLogin());
        #endregion
    }
}
