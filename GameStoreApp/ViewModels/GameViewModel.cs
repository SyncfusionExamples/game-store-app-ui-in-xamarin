using System;
using System.Collections.ObjectModel;
using GameStoreApp.Models;

namespace GameStoreApp.ViewModels
{
    public class GameViewModel
    {
        public ObservableCollection<Games> Games { get; set; }
        public ObservableCollection<Favorites> Favorites { get; set; }

        public GameViewModel()
        {
            Games = new ObservableCollection<Games>()
            {
               new Games { Picture="EpicGame", Title="Epic Games", Status="Available", Rating=5 },
               new Games { Picture="Steam", Title="Steam", Status="Available", Rating=4 }
            };

            Favorites = new ObservableCollection<Favorites>()
            {
                new Favorites { Picture="Game1",Title="Read Dead Redem", Description="Rockstar",Rating="⭐ 4.5 (120)", Price="$20.00" },
                new Favorites { Picture="Game2",Title="The Elder Scrolls", Description="Bethesda Softworks",Rating="⭐ 4.0 (1k)", Price="$12.00" },
                new Favorites { Picture="Game3",Title="AC Oddysey", Description="Ubisoft Montreal",Rating="⭐ 4.0 (1k)", Price="$20.00" },
                new Favorites { Picture="Game4",Title="ac origins", Description="Ubisoft Montreal",Rating="⭐ 4.3 (203)", Price="32.00" }

            };
        }
    }
}
