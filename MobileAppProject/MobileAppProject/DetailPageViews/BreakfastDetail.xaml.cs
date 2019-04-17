using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileAppProject.DetailPageViews
{
	public partial class BreakfastDetail : ContentPage
	{
		public BreakfastDetail (string Name, string Ingredients, string source)
		{
			InitializeComponent ();

            // Making local instances of Json info extracted in Breakfast page
            BreakfastDetailName.Text = Name;
            BreakfastDetailIngredient.Text = Ingredients;
            BreakfastDetailImage.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
		}
	}
}