using Fortnite.Info.Model;
using Fortnite.Info.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fortnite.Info.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StorePage : ContentPage
    {
        public StorePage()
        {
            InitializeComponent();
            LoadStore();
            ItemsStore.Refreshing += ItemsStore_Refreshing;
        }

        private void LoadStore()
        {
            StoreController store = new StoreController();
            ItemsStore.ItemsSource = store.GetCurrentStore().shop;
        }

        private void ItemsStore_Refreshing(object sender, EventArgs e)
        {
            LoadStore();
            ItemsStore.IsRefreshing = false;
        }

    }
}