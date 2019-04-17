using MobileAppProject.PageViews;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileAppProject
{
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var page = new Breakfast();
            //NavigationPage.SetHasNavigationBar(page, true);
            //NavigationPage.SetBackButtonTitle(page, "Back");


            Navigation.PushAsync(page);

            //NavigationPage.SetHasBackButton(page, true);

        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            var page = new Lunch();

            Navigation.PushAsync(page);
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            var page = new Lunch();

            Navigation.PushAsync(page);
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            var page = new Breakfast();

            Navigation.PushAsync(page);
        }

        private void Button_Clicked5(object sender, EventArgs e)
        {
            var page = new Breakfast();

            Navigation.PushAsync(page);
        }
    }
}