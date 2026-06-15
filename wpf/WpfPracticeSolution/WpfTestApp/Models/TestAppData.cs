using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace WpfTestApp.Models
{
    public class TestAppData
    {
        [JsonProperty("item")]
        public ObservableCollection<TestAppItem> Items { get; set; }
    }
}
