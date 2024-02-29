using Newtonsoft.Json;
using System.Text;
using Winform_QLBN.Models;

namespace Winform_QLBN.Services
{
    internal class Data
    {
        private static string apiUrl = "https://4fbc-171-243-50-227.ngrok-free.app/api/Benhnhan";
        public async Task<List<Benhnhan>> LoaddataAsync()
        {
            List<Benhnhan>? result = new List<Benhnhan>();
            try
            {
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json"); // Sửa đổi Accept header

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<Benhnhan>>(content);
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối CSDL");
                    //Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối internet");
            }

            return result!;
        }


        public async Task<bool> InsertdataAsync(Benhnhan benhnhan)
        {
            string jsonData = JsonConvert.SerializeObject(benhnhan);
            try
            {
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json"); // Sửa đổi Accept header
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("xảy ra lỗi khi lưu dữ liệu ở API");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("xảy ra lỗi khi truyền dữ liệu");
                return false;
            }
        }

        public Boolean Updatedata(Benhnhan benhnhan)
        {
            return true;
        }

        public Boolean Deletedata(Benhnhan benhnhan)
        {
            return true;
        }
    }
}
