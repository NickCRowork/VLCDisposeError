using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using VLCDisposeError.Views;

namespace VLCDisposeError.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public Command OpenVideo { get; }
        public MainPageViewModel()
        {
            OpenVideo = new Command(GotoVideo);
        }
        private async void GotoVideo()
        {
            var navpage = new NavigationPage(new VideoPlayerPage());
            await Application.Current.MainPage.Navigation.PushModalAsync(navpage);
        }
    }
}
