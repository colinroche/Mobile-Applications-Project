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
	public partial class Lunch : ContentPage
	{
        // Calling itmes from RecipeModel
        private ObservableCollection<RecipeModel> lunchList;
        public Lunch()
        {
            InitializeComponent();
            BindingContext = this;

            var assembly = typeof(Lunch).GetTypeInfo().Assembly;
            // Calling Lunch.json
            Stream stream = assembly.GetManifestResourceStream("MobileAppProject.JsonFiles.Lunch.json");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                List<RecipeModel> myList = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
                lunchList = new ObservableCollection<RecipeModel>(myList);
                // Set ListView with item got from deserializing json
                MyListViewLunch.ItemsSource = lunchList;
            }
        }

        // EventHandler for itemTapped - item selected in ListView
        private async void LunchSelected(Object sender, ItemTappedEventArgs e)
        {
            // Variable will take items for RecipeModel and pass them asynchronously to the LunchDetial page
            var lunchDetails = e.Item as RecipeModel;
            await Navigation.PushAsync(new LunchDetail(lunchDetails.Name, lunchDetails.Ingredients, lunchDetails.Image));
        }

    }
}