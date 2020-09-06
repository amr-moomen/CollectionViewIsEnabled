using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace collectionViewDisable
{
    public class MobileNasoption
    {
        public string ItemTitle { get; set; }
        public string ItemImageURL { get; set; }

    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class myMain : ContentPage
    {
        IEnumerable ItemsSource1;
        public myMain()
        {
            InitializeComponent();
            BindingContext = this;
            ItemsSource1 = new List<MobileNasoption>() {
                new MobileNasoption{ItemTitle="Directory", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="My Profile", ItemImageURL="a2.png" },
                new MobileNasoption{ItemTitle="Change Approvel Request", ItemImageURL="a3.png" },
                new MobileNasoption{ItemTitle="Benefit Items", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="My Leavs", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="Time permisions approval ", ItemImageURL="a6.png" },
                new MobileNasoption{ItemTitle="Expense sheet", ItemImageURL="a7.png" },
                new MobileNasoption{ItemTitle="My Time permisions", ItemImageURL="a8.png" },
                new MobileNasoption{ItemTitle="Attendance Tracking ", ItemImageURL="a9.png" },
                new MobileNasoption{ItemTitle="Attendance Sign in / out", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="Time permisions Request", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="My Benefit", ItemImageURL="a2.png" },
                new MobileNasoption{ItemTitle="  My Current Document", ItemImageURL="a3.png" },
                new MobileNasoption{ItemTitle="Benefit Items", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="My Leavs", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="Time permisions approval ", ItemImageURL="a6.png" },
                new MobileNasoption{ItemTitle="Change Approvel Request", ItemImageURL="a3.png" },
                new MobileNasoption{ItemTitle="Expense sheet", ItemImageURL="a7.png" },
                new MobileNasoption{ItemTitle="My Time permisions", ItemImageURL="a8.png" },
            };
        }
        protected override void OnAppearing()
        {
            CollectionView.ItemsSource = ItemsSource1;
            CollectionView.IsEnabled = false;
        }
        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            toastSTL.BackgroundColor = new Color(0, 0, 0);
            toastlbl.Text = ((MobileNasoption)e.CurrentSelection[0]).ItemTitle;         
            overlayToast.IsVisible = true;
            toastSTL.Opacity = 0.7;
            await toastSTL.FadeTo(0.2, 2000U, Easing.Linear);
            overlayToast.IsVisible = false;
        }   
    }
}