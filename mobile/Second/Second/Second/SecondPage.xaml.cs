using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Second
{	
	public partial class SecondPage : ContentPage
	{	
		public SecondPage ()
		{
			InitializeComponent ();
            //ImgLogo1.Source = ImageSource.FromFile("Logo1");
            //ImgLogo2.Source = ImageSource.FromFile("Logo2");
            NavigationPage.SetHasBackButton(this, false);
            //Title = "Login";

            //NavigationPage.SetHasBackButton(this, false);

            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("3071CF");
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}

