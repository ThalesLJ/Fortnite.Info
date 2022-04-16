using Fortnite.Info.Model;
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
            List<ItemStore> items = new List<ItemStore>()
            {
                new ItemStore{ name = "Sorina", description = "The darkest shadows fall from moonlight.", url = "https://media.fortniteapi.io/images/displayAssets/v2/DAv2_CID_A_379_F_VampireHunter/MI_CID_A_379_F_VampireHunter.png", price = "1500 V-Bucks" },
                new ItemStore{ name = "Winkypaw", description = "eaving pawprints on everything.", url = "https://media.fortniteapi.io/images/displayAssets/v2/DAv2_Wrap_444_LeatherJacketPurple/MI_Wrap_444_LeatherJacketPurple.png", price = "300 V-Bucks" },
                new ItemStore{ name = "Brite Bomber", description = "The future looks bright...", url = "https://media.fortniteapi.io/images/displayAssets/v2/DAv2_CID_044_F_SciPop/MI_CID_044_F_SciPop.png", price = "2000 V-Bucks" },
                new ItemStore{ name = "Brite Gunner", description = "Look on the bright side.", url = "https://media.fortniteapi.io/images/displayAssets/v2/DAv2_CID_112_M_Brite/MI_CID_112_M_Brite.png", price = "2000 V-Bucks" },
                new ItemStore{ name = "Rainbow Smash", description = "Beat the stuffing out of 'em.", url = "https://media.fortniteapi.io/images/displayAssets/v2/DAv2_Pickaxe_ID_026_Brite/MI_Pickaxe_ID_026_Brite.png", price = "500 V-Bucks" }
            };
            ItemsStore.ItemsSource = items;
        }
    }
}