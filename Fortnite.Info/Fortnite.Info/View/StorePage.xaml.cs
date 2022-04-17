using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fortnite.Info.Model;
using Fortnite.Info.Controller;

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
            StoreResponse currentStore = store.GetCurrentStore();
            if(currentStore != null) ItemsStore.ItemsSource = currentStore.shop;
        }

        private void ItemsStore_Refreshing(object sender, EventArgs e)
        {
            LoadStore();
            ItemsStore.IsRefreshing = false;
        }

    }
}