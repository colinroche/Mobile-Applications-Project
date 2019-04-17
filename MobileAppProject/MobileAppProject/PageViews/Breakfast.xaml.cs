using MobileAppProject.DetailPageViews;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileAppProject.PageViews
{
	public partial class Breakfast : ContentPage
	{
        // Calling itmes from RecipeModel
        private ObservableCollection<RecipeModel> breakfastList;
        public Breakfast ()
		{
			InitializeComponent ();
            BindingContext = this;

            var assembly = typeof(Breakfast).GetTypeInfo().Assembly;
            // Calling Breakfast.json
            Stream stream = assembly.GetManifestResourceStream("MobileAppProject.JsonFiles.Breakfast.json");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                List<RecipeModel> myList = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
                breakfastList = new ObservableCollection<RecipeModel>(myList);
                // Set ListView with item got from deserializing json
                MyListView1.ItemsSource = breakfastList;
            }
        }

        // EventHandler for itemTapped - item selected in ListView
        private async void BreakfastSelected(Object sender , ItemTappedEventArgs e)
        {
            // Variable will take items for RecipeModel and pass them asynchronously to the BreakfastDetial page
            var breakfastDetails = e.Item as RecipeModel;
            await Navigation.PushAsync(new BreakfastDetail(breakfastDetails.Name, breakfastDetails.Ingredients, breakfastDetails.Image));
        }
	}
}