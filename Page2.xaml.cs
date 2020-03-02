using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
namespace APP3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        string dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "databse1.db");


        public Page2()
        {
            InitializeComponent();
        }
        private async void success(object sender, System.EventArgs e)
        {
            var df = new SQLiteConnection(dbpath);
            df.CreateTable<class3>();
            class3 Class3 = new class3()
            {

                username2 = userlogin.Text,

                password = passwordID2.Text

            };
            
            df.Insert(Class3);
            Class1 class1 = new Class1();
            var c = class1.username;
            var d = class1.password;
            if (c == Class3.username2 && d == Class3.password)
            {

                await Navigation.PushAsync(new Page3());
            }
            else
                    await DisplayAlert(null,"please enter the correct data"," ");

            } 
          




        }


    }


    
