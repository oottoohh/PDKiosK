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
    public class BillsController : Controller
    {
        HelperClientHttp _api = new HelperClientHttp();
        public async Task<IActionResult> BillsView()
        {
            List<Bills> Bills = new List<Bills>();
            HttpClient client = await _api.InitialAsync(); //dari Global Variable
            HttpResponseMessage res = await client.GetAsync("/api/Bills"); //URL GET DATA ke UserProfile check di https://pdjayaservice.azurewebsites.net
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var output = JsonConvert.DeserializeObject<OutputData>(result); //Output data di Helper fungsi untuk menampung data sementara
                if (output != null && output.IsSucceed)
                {
                    Bills = ((JArray)output.Data).ToObject<List<Bills>>(); // Pass data dari output.Data ke list userprofile class
                }
            }
            return View(Bills);
        }

        public IActionResult CreateBills()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] Bills dtForm)
        {
            if (ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(dtForm), Encoding.UTF8, "application/json");
                HttpClient client = await _api.InitialAsync();
                var result = await client.PostAsync("/api/Bills", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
            return RedirectToAction(nameof(BillsView));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            List<Bills> Bills = new List<Bills>();
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.GetAsync("/api/Bills/" + id);
            var result = await res.Content.ReadAsStringAsync();
            var o = JObject.Parse(result);
            var data = JsonConvert.DeserializeObject<Bills>(o.Root.ToString());
            return View(data);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, [Bind] Bills dtForm)
        {
            if(ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(dtForm), Encoding.UTF8, "application/json");
                HttpClient client = await _api.InitialAsync();
                var result = await client.PutAsync("/api/Bills/"+id, content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
            return RedirectToAction(nameof(BillsView));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            List<Bills> Bills = new List<Bills>();
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.GetAsync("/api/Bills/" + id);
            var result = await res.Content.ReadAsStringAsync();
            var o = JObject.Parse(result);
            var data = JsonConvert.DeserializeObject<Bills>(o.Root.ToString());
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id)
        {
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.DeleteAsync("/api/Bills/" + id);
            string resultContent = await res.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
            return RedirectToAction("BillsView");
        }
    }
}