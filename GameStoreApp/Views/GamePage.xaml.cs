using System;
using System.Collections.Generic;
using Xamarin.Forms;
using GameStoreApp.ViewModels;

namespace GameStoreApp.Views
{
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();
            BindingContext = new GameViewModel();
        }
    }
}
