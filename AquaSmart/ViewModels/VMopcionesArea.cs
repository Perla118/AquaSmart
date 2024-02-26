using AquaSmart.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AquaSmart.ViewModels
{
    public class VMopcionesArea : BaseViewModel
    {
        #region VARIABLES
        private bool _ActivarRiego;
        private bool _DesactivarRiego;
        private bool _VerSensores;
        private bool _VerActuadores;
        #endregion
        #region CONSTRUCTOR
        public VMopcionesArea(INavigation navigation)
        {
            Navigation = navigation;
            VerSensores = false;
            VerActuadores = false;

        }
        #endregion
        #region OBJETOS
        public bool VerSensores
        {
            get => _VerSensores;
            set
            {
                _VerSensores = value;
                OnPropertyChanged();
            }
        }
        public bool VerActuadores
        {
            get => _VerActuadores;
            set
            {
                _VerActuadores = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region PROCESOS
        public async Task ConfHorario()
        {
            await Navigation.PushAsync(new ConfArea());
        }
        public async Task Historial()
        {
            await Navigation.PushAsync(new HistorialRiego());
        }
        private void MostrarSensores()
        {
            VerSensores = !VerSensores;
        }
        private void MostrarActuadores()
        {
            VerActuadores = !VerActuadores;
        }
        public async void Alerta()
        {
            await DisplayAlert("MENSAJE", "El riego se activará en 15 segundos", "Salir");
        }
        #endregion

        #region COMANDOS
        public ICommand Confcommand => new Command(async () => await ConfHorario());
        public ICommand Historiaal => new Command(async () => await Historial());
        public ICommand MostrarSensoresCommand => new Command(MostrarSensores);
        public ICommand MostrarActuadoresCommand => new Command(MostrarActuadores);
        public ICommand AlertaCommand => new Command(Alerta);
        #endregion
    }
}
