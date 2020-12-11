using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinApiRequest.Models;
using XamarinApiRequest.Services;
using Xamarin.Essentials;

namespace XamarinApiRequest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand GetRandomGameCommand => new Command(GetRandomGame);
        public string CurrentGame { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        async void GetRandomGame()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                IGameRandomizerApiService service = new GameRandomizerApiService();
                Game game = await service.GetRandomAsync();
                if (game != null)
                {
                    CurrentGame = $"Game: {game.name}";
                    
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "There is no internet connection", "OK");
            }
        }
    }
}
