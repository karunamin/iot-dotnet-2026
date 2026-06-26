using Newtonsoft.Json;
using ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;

namespace WpfProductAdmin.Services
{
    internal class ApiServices
    {
        public async Task<ObservableCollection<Product>> GetProducts()
        {
            string serviceUrl = "http://localhost:5276/api/products";

            try
            {
                // 공공데이터포털과 완전 동일
                using HttpClient client = new HttpClient();

                string json = await client.GetStringAsync(serviceUrl);

                // 역직렬화
                var response = JsonConvert.DeserializeObject<ObservableCollection<Product>>(json);

                return response;
            }
            catch(Exception ex)
            {
                return new ObservableCollection<Product>();
            }
        }
    }
}
