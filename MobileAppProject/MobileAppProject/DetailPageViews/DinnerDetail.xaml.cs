using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileAppProject.DetailPageViews
{
	public partial class DinnerDetail : ContentPage
	{
		public DinnerDetail (string Name, string Ingredients, string source)
		{
			InitializeComponent ();

            // Making local instances of Json info extracted in Breakfast page
            DinnerDetailName.Text = Name;
            DinnerDetailIngredient.Text = Ingredients;
            DinnerDetailImage.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
        }
	}
}