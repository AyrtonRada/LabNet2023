using Newtonsoft.Json;
using Practica4.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Practica4.MVC.Controllers
{
    public class RickYMortyApiController : Controller
    {
        // GET: RickYMortyApi
        public async Task<ActionResult> Index()
        {
            HttpClient httpClient = new HttpClient();
            string url = "https://rickandmortyapi.com/api/character";
            var json = await httpClient.GetStringAsync(url);
                                        
            dynamic listApi = JsonConvert.DeserializeObject(json);

            var seccionResult = listApi.results;

            List<RickYMortyApiView> listRickMortyView = new List<RickYMortyApiView>();

            foreach (var item in seccionResult)
            {
                RickYMortyApiView rickMortyApi = new RickYMortyApiView()
                {
                    Name = item.name,
                    Status = item.status,
                    Species = item.species,
                    Gender = item.gender                    
                };
                listRickMortyView.Add(rickMortyApi);
            }
            return View(listRickMortyView);         
            
        }
    }
}