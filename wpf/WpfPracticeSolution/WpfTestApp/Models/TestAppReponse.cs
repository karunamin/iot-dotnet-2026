using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace WpfTestApp.Models
{
    public class TestAppReponse
    {
        [JsonProperty("getShoppingKr")]
        public GetShoppingKr getShoppingKr { get; set; }
    }

    public class GetShoppingKr
    {
        [JsonProperty("item")]
        public ObservableCollection<TestAppItem> item { get; set; }
    }
}