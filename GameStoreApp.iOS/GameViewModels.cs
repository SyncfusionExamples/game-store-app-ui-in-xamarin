using System;
using System.Collections.ObjectModel;
using GameStoreApp.Models;

namespace GameStoreApp.ViewModels
{
    public class GameViewModels
    {
        public ObservableCollection<Games> Games { get; set; }
        public ObservableCollection<Favorites> Favorites { get; set; }

        public GameViewModels()
        {
            Games = new ObservableCollection<Games>()
            {
                new Games { Title = "Epic Games", Status="Available", Picture="EpicGame", Rating=5},
                new Games { Title = "Steam", Status="Available", Picture="Steam", Rating=4}
            };
            Favorites = new ObservableCollection<Favorites>()
            {
                new Favorites { Title = "Read Dead Redem", Description="Rockstar Games", Rating="⭐ 4.5 (120)", Price="$20.00" , Picture="Game1"},
                new Favorites { Title = "The Elder Scroll", Description="Btheda Softworks", Rating="⭐ 4.0 (1k)", Price="$12.00" , Picture="Game2"},
                new Favorites { Title = "AC Odyssey", Description="Ubisoft Montreal", Rating="⭐ 4.0 (1k)", Price="$19.00" , Picture="Game3"},
                new Favorites { Title = "AC Origins", Description="Ubisoft Montreal", Rating="⭐ 4.8 (203)", Price="32.00" , Picture="Game4"}
            };
        }
    }
}
