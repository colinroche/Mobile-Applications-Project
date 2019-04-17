using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileAppProject.DetailPageViews
{
	public partial class DessertDetail : ContentPage
	{
		public DessertDetail (string Name, string Ingredients, string source)
		{
			InitializeComponent ();

            // Making local instances of Json info extracted in Dessert page
            DessertDetailName.Text = Name;
            DessertDetailIngredient.Text = Ingredients;
            DessertDetailImage.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
        }
	}
}