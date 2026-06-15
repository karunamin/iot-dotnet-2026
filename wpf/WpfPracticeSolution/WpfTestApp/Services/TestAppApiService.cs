using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Web;
using WpfTestApp.Helpers;
using WpfTestApp.Models;

namespace WpfTestApp.Services
{
    public class TestAppApiService
    {
        private string ServiceKey { get; set; }

        public TestAppApiService()
        {
            ServiceKey = Environment.GetEnvironmentVariable("BUSAN_SHOPPING_API_KEY");
        }

        public async Task<ObservableCollection<TestAppItem>> GetTestAppsAsync(int pageNo = 1, int numOfRows = 10)
        {
            try
            {
                using HttpClient client = new HttpClient();

                string url =
                    $"https://apis.data.go.kr/6260000/ShoppingService/getShoppingKr" +
                    $"?serviceKey={ServiceKey}" +
                    $"&pageNo={pageNo}" +
                    $"&numOfRows={numOfRows}" +
                    $"&resultType=json";

                string json = await client.GetStringAsync(url);
                System.Diagnostics.Debug.WriteLine(json);
                // 반드시 로그 확인 (중요)
                Common.logger.Info(json);

                var data = JsonConvert.DeserializeObject<TestAppReponse>(json);

                return data?.getShoppingKr?.item
                       ?? new ObservableCollection<TestAppItem>();


            }
            catch (Exception ex)
            {
                Common.logger.Error(ex, "API 호출 실패");
                return new ObservableCollection<TestAppItem>();
            }
        }
    }
}