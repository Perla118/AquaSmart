using AquaSmart.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AquaSmart.ViewModels
{
    public class VMlogin : BaseViewModel
    {
        #region VARIABLES
        #endregion
        #region CONTRUCTOR
        public VMlogin(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS

        #endregion
        #region PROCESOS
        public async Task IraMenu()
        {
            await Navigation.PushAsync(new Hamburguesa());
        }
        public async Task IraRegistro()
        {
            await Navigation.PushAsync(new Regist());
        }
        public async Task ContraOlvidada()
        {
            await Navigation.PushAsync(new ForgetPassword());
        }

        #endregion
        #region COMANDOS
        public ICommand Menu => new Command(async () => await IraMenu());
        public ICommand Contraseña => new Command(async () => await ContraOlvidada());
        public ICommand Registro => new Command(async () => await IraRegistro());
        #endregion
    }
}
