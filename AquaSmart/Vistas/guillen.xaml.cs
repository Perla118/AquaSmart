﻿using AquaSmart.ViewModels;
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
    public partial class guillen : ContentPage
    {
        public guillen()
        {
            InitializeComponent();
            BindingContext = new VMlogin(Navigation);
        }
    }
}