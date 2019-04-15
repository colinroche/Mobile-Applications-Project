using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace MobileAppProject
{
	public partial class Recipe : ContentPage
	{
        private ObservableCollection<RecipeModel> myObject;
		public Recipe ()
		{
			InitializeComponent ();
            BindingContext = this;

            var assembly = typeof(Recipe).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("MobileAppProject.JsonFiles.Breakfast.json");
            Stream stream2 = assembly.GetManifestResourceStream("MobileAppProject.JsonFiles.Lunch.json");
            Stream stream3 = assembly.GetManifestResourceStream("MobileAppProject.JsonFiles.Dinner.json");
            Stream stream4 = assembly.GetManifestResourceStream("MobileAppProject.JsonFiles.Dessert.json");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                List<RecipeModel> myList = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
                myObject = new ObservableCollection<RecipeModel>(myList);
                MyListView.ItemsSource = myObject;
            }

            using (var reader = new System.IO.StreamReader(stream2))
            {
                var json = reader.ReadToEnd();

                List<RecipeModel> myList = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
                myObject = new ObservableCollection<RecipeModel>(myList);
                MyListView2.ItemsSource = myObject;
            }

            using (var reader = new System.IO.StreamReader(stream3))
            {
                var json = reader.ReadToEnd();

                List<RecipeModel> myList = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
                myObject = new ObservableCollection<RecipeModel>(myList);
                MyListView3.ItemsSource = myObject;
            }

            using (var reader = new System.IO.StreamReader(stream4))
            {
                var json = reader.ReadToEnd();

                List<RecipeModel> myList = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
                myObject = new ObservableCollection<RecipeModel>(myList);

                MyListView4.ItemsSource = myObject;
            }
        }
	}
}