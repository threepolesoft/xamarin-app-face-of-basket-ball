using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using faceofbasketball.ViewModels;
using Xamarin.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using System.Threading.Tasks;
using faceofbasketball.View;
using faceofbasketball;
using faceofbasketball.Models;

namespace faceofbasketball.ViewModels
{
    public class data  
    {
        public ObservableCollection<Item> Items { get; set; }

        public data()
        {
            try
            {
                Items = new ObservableCollection<Item>();

                string fn = "data.json";

                var assembly = typeof(MainPage).GetTypeInfo().Assembly;

                Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{fn}");

                var reader = new StreamReader(stream);

                var js = reader.ReadToEnd();

                stream.Close();

                Items = JsonConvert.DeserializeObject<ObservableCollection<Item>>(js);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

    }
}
