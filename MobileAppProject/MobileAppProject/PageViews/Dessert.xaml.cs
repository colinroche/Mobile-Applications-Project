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
	public partial class Dessert : ContentPage
	{
        // Calling itmes from RecipeModel
        private ObservableCollection<RecipeModel> dessertList;
        public Dessert()
        {
            InitializeComponent();
            BindingContext = this;

            var assembly = typeof(Dessert).GetTypeInfo().Assembly;
            // Calling Dessert.json
            Stream stream = assembly.GetManifestResourceStream("MobileAppProject.JsonFiles.Dessert.json");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                List<RecipeModel> myList = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
                dessertList = new ObservableCollection<RecipeModel>(myList);
                // Set ListView with item got from deserializing json
                MyListViewDessert.ItemsSource = dessertList;
            }
        }

        // EventHandler for itemTapped - item selected in ListView
        private async void DessertSelected(Object sender, ItemTappedEventArgs e)
        {
            // Variable will take items for RecipeModel and pass them asynchronously to the DessertDetial page
            var dessertDetails = e.Item as RecipeModel;
            await Navigation.PushAsync(new DessertDetail(dessertDetails.Name, dessertDetails.Ingredients, dessertDetails.Image));
        }
    }
}