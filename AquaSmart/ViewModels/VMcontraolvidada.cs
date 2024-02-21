using AquaSmart.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AquaSmart.ViewModels
{
    public class VMcontraolvidada : BaseViewModel
    {
        #region VARIABLES

        #endregion

        #region CONSTRUCTOR
        public VMcontraolvidada(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion

        #region OBJETOS

        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PushAsync(new Login());
        }
        #endregion
        #region COMANDOS
        public ICommand Iniciar => new Command(async () => await Volver());

        #endregion
    }
}
