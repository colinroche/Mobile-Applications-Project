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
	public partial class Dinner : ContentPage
	{
        // Calling itmes from RecipeModel
        private ObservableCollection<RecipeModel> dinnerList;
        public Dinner()
        {
            InitializeComponent();
            BindingContext = this;

            var assembly = typeof(Dinner).GetTypeInfo().Assembly;
            // Calling Dinner.json
            Stream stream = assembly.GetManifestResourceStream("MobileAppProject.JsonFiles.Dinner.json");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                List<RecipeModel> myList = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
                dinnerList = new ObservableCollection<RecipeModel>(myList);
                // Set ListView with item got from deserializing json
                MyListViewDinner.ItemsSource = dinnerList;
            }
        }

        // EventHandler for itemTapped - item selected in ListView
        private async void DinnerSelected(Object sender, ItemTappedEventArgs e)
        {
            // Variable will take items for RecipeModel and pass them asynchronously to the DinnerDetial page
            var dinnerDetails = e.Item as RecipeModel;
            await Navigation.PushAsync(new DinnerDetail(dinnerDetails.Name, dinnerDetails.Ingredients, dinnerDetails.Image));
        }
    }
}