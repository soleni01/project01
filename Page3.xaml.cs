using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APP3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        private ObservableCollection<Class1> Mylist
        {
            get { return Mylist; }
            set { Mylist = value; }
        }
        public Page3()
        {
            this.BindingContext = this;
            Mylist = new ObservableCollection<Class1>();
            for (int i = 1; i < 5; i++)
            {
                Mylist.Add(new Class1() { fullname = "user" + i.ToString() });

            }
          //  Class1list.ItemsSource = Mylist;
        }

    }
    }
