using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PDJaya.WebApp.Models;
using PDJaya.WebApp.Helper;
using System.Net.Http;
using IdentityModel.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace PDJaya.WebApp.Controllers
{
    public class MarketController : Controller
    {
        HelperClientHttp _api = new HelperClientHttp(); //Check di Helper fungsi
        public async Task<IActionResult> Index()
        {
            List<Market> Market = new List<Market>();
            HttpClient client = await _api.InitialAsync(); //dari Global Variable
            HttpResponseMessage res = await client.GetAsync("/api/Markets"); //URL GET DATA ke Market check di https://pdjayaservice.azurewebsites.net
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var output = JsonConvert.DeserializeObject<OutputData>(result); //Output data di Helper fungsi untuk menampung data sementara
                if (output != null && output.IsSucceed)
                {
                    Market = ((JArray)output.Data).ToObject<List<Market>>(); // Pass data dari output.Data ke list Market class
                }
            }
            return View(Market); //menampilkan data
        }

        public IActionResult CreateMarket()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] Market dtForm)
        {
            if (ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(dtForm), Encoding.UTF8, "application/json");
                HttpClient client = await _api.InitialAsync();
                var result = await client.PostAsync("/api/Markets", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            List<Market> Market = new List<Market>();
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.GetAsync("/api/Markets/" + id);
            var result = await res.Content.ReadAsStringAsync();
            var o = JObject.Parse(result);
            var data = JsonConvert.DeserializeObject<Market>(o.Root.ToString());
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id)
        {
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.DeleteAsync("/api/Markets/" + id);
            string resultContent = await res.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            List<Market> Market = new List<Market>();
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.GetAsync("/api/Markets/" + id);
            var result = await res.Content.ReadAsStringAsync();
            var o = JObject.Parse(result);
            var data = JsonConvert.DeserializeObject<Market>(o.Root.ToString());
            return View(data);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, [Bind]Market dtform)
        {
            HttpClient client = await _api.InitialAsync();
            StringContent content = new StringContent(JsonConvert.SerializeObject(dtform), Encoding.UTF8, "application/json");
            HttpResponseMessage res = await client.PutAsync("/api/Markets/" + id, content);
            string resultContent = await res.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
            return RedirectToAction("Index");
        }
    }
}
