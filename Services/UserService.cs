using AggregatorMicroservice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AggregatorMicroservice.Services
{
    public class UserService : IUserService
    {
        private HttpClient _httpClient;
        string Baseurl = "http://usermicroservice_usermicroservice_1/";

        public UserService()
        {
            _httpClient = new HttpClient();
            //Passing service base url  
            _httpClient.BaseAddress = new Uri(Baseurl);

            _httpClient.DefaultRequestHeaders.Clear();
            //Define request data format  
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {

            User user = null;
            HttpResponseMessage Res = await _httpClient.GetAsync("api/user/" + userId);
            if (Res.IsSuccessStatusCode)
            {
                var userResponse = Res.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<User>(userResponse);
            }

            return user;
        }
    }
}
