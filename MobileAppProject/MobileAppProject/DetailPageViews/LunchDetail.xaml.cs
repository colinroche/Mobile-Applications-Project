using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileAppProject.DetailPageViews
{
	public partial class LunchDetail : ContentPage
	{
		public LunchDetail (string Name, string Ingredients, string source)
		{
			InitializeComponent ();

            // Making local instances of Json info extracted in Lunch page
            LunchDetailName.Text = Name;
            LunchDetailIngredient.Text = Ingredients;
            LunchDetailImage.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
        }
	}
}