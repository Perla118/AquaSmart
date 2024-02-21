using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaSmart.Droid
{
    [Activity(Label = "AquaSmart", Icon = "@mipmap/icon", Theme = "@style/nuevoTema", 
        MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //pARA NO PERDER LOS PERMISOS DE NUESTRO MAIN ACTIVITY, TODO LO QUE ESTA AHÍ
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            // Create your application here
        }
    }
}