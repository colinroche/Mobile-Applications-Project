using MobileAppProject.PageViews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace MobileAppProject
{
	public partial class Home : ContentPage
	{
        Label orientationLabel;

        public Home ()
		{
            // attempt on setting orientation
            orientationLabel = new Label();
            orientationLabel.VerticalOptions = LayoutOptions.Center;
            orientationLabel.HorizontalOptions = LayoutOptions.Center;
            Content = orientationLabel;

			InitializeComponent ();
        }

        // Method to store page orientation
        protected override void OnSizeAllocated(double width, double height)
        {
            // call the base
            base.OnSizeAllocated(width, height);

            // check dimensions to deteremine screen orientation
            if (width > height)
                Debug.WriteLine("Landscape");
            else
                Debug.WriteLine("Portrait");
        }

        // Button clicks navigate to new page
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
            var page = new Dinner();

            Navigation.PushAsync(page);
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            var page = new Dessert();

            Navigation.PushAsync(page);
        }

    }
}