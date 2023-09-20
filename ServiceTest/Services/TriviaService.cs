using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServiceTest.Services
{
   
    public class TriviaService
    {
        private HttpClient client;
        private JsonSerializerOptions options;
        const string URL = @"https://zr8z94hw-44376.euw.devtunnels.ms/AmericanQuestions/";
        public TriviaService()
        {
            client = new HttpClient();
            options = new JsonSerializerOptions()
            {
                WriteIndented = true, PropertyNameCaseInsensitive = true    
            };
        }
        public async Task<string> CheckConnectionAsync()
        {
            try
            {
                var response = await client.GetAsync($"{URL}GetQuestions");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else return "error";
            }
            catch { }
            return null;
        }
    }
}
