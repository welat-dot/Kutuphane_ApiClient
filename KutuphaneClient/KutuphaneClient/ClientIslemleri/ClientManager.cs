using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KutuphaneClient.ClientIslemleri
{
    public class ClientManager
    {
        private Uri baseAdr;
        public ClientManager(string baseAdr)
        {
            this.baseAdr = new Uri(baseAdr);
        }
        public async Task <Result<T>>  GetAsync<T>(string url)
        {
            Result<T> result = new Result<T>();
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = baseAdr;
                Client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response= await Client.GetAsync(url);
               
                if (response.IsSuccessStatusCode)
                {
                    string responseStr = response.Content.ReadAsStringAsync().Result;
                    result.Data = JsonConvert.DeserializeObject<T>(responseStr);
                    result.Mesage = "islem basarılı";
                }

                return result;
            }
        }

        public async Task<Result<TDonus>> PostAsync<T,TDonus>(T data, string url)
        {
            Result<TDonus> result = new Result<TDonus>();
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = baseAdr;
                string strJson = JsonConvert.SerializeObject(data);
                StringContent httpContent = new StringContent(strJson,System.Text.Encoding.UTF8, "application/json");
                var response = await Client.PostAsync(url, httpContent);
                if(response.IsSuccessStatusCode)
                {
                    string  responseStr = response.Content.ReadAsStringAsync().Result;
                    result.Data = JsonConvert.DeserializeObject<TDonus>(responseStr);
                    result.Mesage = "islem basarılı";
                }

                return result;
            }
        }
    }
}
