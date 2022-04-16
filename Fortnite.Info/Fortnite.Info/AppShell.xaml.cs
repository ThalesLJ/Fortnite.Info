using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Fortnite.Info.View;

namespace Fortnite.Info
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(StorePage), typeof(StorePage));
            Routing.RegisterRoute(nameof(MapPage), typeof(MapPage));
        }
    }
}
