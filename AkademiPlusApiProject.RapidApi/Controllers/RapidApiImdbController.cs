using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AkademiPlusApiProject.RapidApi.Models;
using Newtonsoft.Json;

namespace AkademiPlusApiProject.RapidApi.Controllers
{
    public class RapidApiImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<RapidApiImdbViewModel> rapidApiImdbViewModels = new List<RapidApiImdbViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "1f2f77fd8bmshc4a4b0e51125dd5p106ca0jsnc8d908283d18" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                rapidApiImdbViewModels = JsonConvert.DeserializeObject<List<RapidApiImdbViewModel>>(body);
                return View(rapidApiImdbViewModels);
            }
        }
    }
}
