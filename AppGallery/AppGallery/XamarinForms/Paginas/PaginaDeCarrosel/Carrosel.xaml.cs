﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeCarrosel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrosel : CarouselPage
    {
        public Carrosel()
        {
            InitializeComponent();
            CurrentPage = Children[1];
        }
    }
}