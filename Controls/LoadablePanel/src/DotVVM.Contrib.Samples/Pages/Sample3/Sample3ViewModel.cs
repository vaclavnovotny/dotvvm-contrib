using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace DotVVM.Contrib.Samples.Pages.Sample3
{
    public class Sample3ViewModel : MasterViewModel
    {
        public IEnumerable<Item> Items { get; set; } = Enumerable.Repeat(new Item { Id = "id" }, 8);
        public List<string> LoadingItems { get; set; } = new List<string>();


        public class Item
        {
            public string Id { get; set; }
            public string Data { get; set; }
        }
    }
}

