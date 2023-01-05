using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCA.Entities.Models;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;

namespace TCA.Business.GenericService
{
    public class HttpGenericService<T> : IHttpGenericService<T> where T : class, new()
    {
        public IConfiguration _configuration;
        public HttpGenericService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<T>> GetAllModel(string userName, string password)
        {
            var http = new HttpClient();
            var userNamePasword = Encoding.ASCII.GetBytes(($"{userName}:{password}"));
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(userNamePasword));
            var httpServiceUrl = _configuration.GetSection("Services");
            string uri = "";
            var response = await http.GetStringAsync(uri);
            HttpResponseMessage httpResponse = await http.GetAsync(uri);
            JObject dataObj = JObject.Parse(await httpResponse.Content.ReadAsStringAsync());
            List<T> dataList = JsonConvert.DeserializeObject<List<T>>(dataObj["VALUES"].ToString());
            return dataList;
        }
    }
}
