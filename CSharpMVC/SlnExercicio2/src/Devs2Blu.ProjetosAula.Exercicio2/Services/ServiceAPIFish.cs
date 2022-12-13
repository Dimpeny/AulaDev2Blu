using Devs2Blu.ProjetosAula.Exercicio2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.Exercicio2.Services
{
    public class ServiceAPIFish : Controller
    {
        private readonly HttpClient _httpClient;

        public ServiceAPIFish()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<FishDTO>> GetListFish()
        {
            var objJSONResponse = await Get<GetListDataFishDTO>(URL_API);
            var listFish = objJSONResponse.Data;
            return listFish;
        }

        public async Task<List<FishDTO>> GetFishBySpecies(string speciesName)
        {
            var urlSearch = $"{URL_API}/{speciesName}";
            var objJSONResponse = await Get<GetListDataFishDTO>(urlSearch);
            var listFish = objJSONResponse.Data;
            return listFish;
        }

        #region BaseMethods

        public async Task<T> Get<T>(string url)
        {
            var objHttp = await GetAsync(url);

            if (!objHttp.IsSuccessStatusCode)
                return (T)(object)url;

            return await objHttp.Content.ReadFromJsonAsync<T>();

        }

        public async Task<List<T>> GetList<T>(string url)
        {
            var listHttp = await GetAsync(url);

            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();

            return await listHttp.Content.ReadFromJsonAsync<List<T>>();

        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            return await _httpClient.SendAsync(getRequest);
        }
        #endregion


        #region CONSTS

        private const string URL_API = "https://www.fishwatch.gov/api/species";

        #endregion
    }
}
