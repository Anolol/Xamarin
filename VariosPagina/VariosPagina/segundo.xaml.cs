﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VariosPagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class segundo : ContentPage
    {
        public segundo()
        {
            InitializeComponent();
            this.BindingContext = new FormularioViewModel();
        }
    }
}