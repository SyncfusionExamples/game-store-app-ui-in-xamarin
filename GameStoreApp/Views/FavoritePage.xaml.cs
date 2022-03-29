using System;
using System.Collections.Generic;
using GameStoreApp.ViewModels;
using Xamarin.Forms;

namespace GameStoreApp.Views
{
    public partial class FavoritePage : ContentPage
    {
        public FavoritePage()
        {
            InitializeComponent();
            BindingContext = new GameViewModel();

        }
    }
}
