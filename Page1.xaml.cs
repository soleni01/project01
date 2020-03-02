using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;

namespace APP3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        string dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "databse1.db");

        public Page1()
        {
            InitializeComponent();

        }
        public async void log(object sender, System.EventArgs e)
        {
            {
                var df = new SQLiteConnection(dbpath);
                df.CreateTable<Class1>();
                
                Class1  class1 = new Class1()
                {
                   
                fullname = fname.Text,
                    username = usrname.Text,
                   
                    emailadress=email.Text,
                    password=password1.Text,
                    phonenumber = phonenumber.Text,
                    gender =gender1.Text
                };
                df.Insert(class1);
                

                await DisplayAlert(null, class1.fullname + "your data saved succesfully", "ok");
                
            }
            
               
            }
        
        }
    }
