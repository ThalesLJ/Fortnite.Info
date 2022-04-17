using System;
using System.Collections.Generic;
using System.Text;

namespace Fortnite.Info.Model
{
    public class StoreResponse
    {
        public bool result { get; set; }
        public List<Shop> shop { get; set; }
    }

    public class Shop
    {
        public string displayName { get; set; }
        public string displayDescription { get; set; }
        public List<ItemAssets> displayAssets { get; set; }
        public ItemPrice price { get; set; }
    }

    public class ItemAssets
    {
        public string url { get; set; }
        public string full_background { get; set; }
    }

    public class ItemPrice
    {
        public int finalPrice { get; set; }
    }
}
