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

        public event PropertyChangedEventHandler PropertyChanged;

        async void GetRandomGame()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                IGameRandomizerApiService service = new GameRandomizerApiService();
                Game game = await service.GetRandomAsync();
                if (game != null)
                {
                    await App.Current.MainPage.DisplayAlert("Succes", game.name, "OK");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "There is no internet connection", "OK");
            }
        }
    }
}
