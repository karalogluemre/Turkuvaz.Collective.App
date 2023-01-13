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
using TCA.DataAccess.Dtos;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Nodes;

namespace TCA.Business.GenericService
{
    public class HttpGenericService<T> : IHttpGenericService<T> where T : class, new()
    {
        public IConfiguration _configuration;
        public HttpGenericService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<T>> GetAllModel(string? userName, string? password)
        {
            List<T> listModel = new List<T>();
            var model = listModel.GetType().FullName.Split("Models.").Last().Split(",")[0];
            var appSettingUrl = _configuration.GetSection(model + ":Url").Value;
            var appSettingUserName = _configuration.GetSection(model + ":UserName").Value;
            var appSettingPassword = _configuration.GetSection(model + ":Password").Value;
            var http = new HttpClient();
            var userNamePasword = Encoding.ASCII.GetBytes(($"{appSettingUserName}:{appSettingPassword}"));
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(userNamePasword));
            string uri = appSettingUrl;
            var response = await http.GetStringAsync(uri);
            HttpResponseMessage httpResponse = await http.GetAsync(uri);
            JObject dataObj = JObject.Parse(await httpResponse.Content.ReadAsStringAsync());
            List<T> dataList = JsonConvert.DeserializeObject<List<T>>(dataObj["VALUES"].ToString());
            return dataList;
        }

        public async Task<List<T>> GetValuesAndBrevityAllModel(string userName, string password)
        {
            List<T> listModel = new List<T>();
            var model = listModel.GetType().FullName.Split("Models.").Last().Split(",")[0];
            var appSettingUrl = _configuration.GetSection(model + ":Url").Value;
            var appSettingUserName = _configuration.GetSection(model + ":UserName").Value;
            var appSettingPassword = _configuration.GetSection(model + ":Password").Value;
            var http = new HttpClient();
            var userNamePasword = Encoding.ASCII.GetBytes(($"{appSettingUserName}:{appSettingPassword}"));
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(userNamePasword));
            string uri = appSettingUrl;
            var response = await http.GetStringAsync(uri);
            HttpResponseMessage httpResponse = await http.GetAsync(uri);
            JObject dataObj = JObject.Parse(await httpResponse.Content.ReadAsStringAsync());
            List<T> dataList = JsonConvert.DeserializeObject<List<T>>(dataObj["VALUES"]["OZLUK"].ToString());
            return dataList;
        }
    }
}
