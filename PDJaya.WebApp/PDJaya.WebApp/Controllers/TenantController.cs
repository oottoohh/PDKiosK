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
    public class TenantController : Controller
    {
        HelperClientHttp _api = new HelperClientHttp();
        public async Task<IActionResult> TenantView()
        {
            List<Tenant> Tenant = new List<Tenant>();
            HttpClient client = await _api.InitialAsync(); 
            HttpResponseMessage res = await client.GetAsync("/api/Tenants"); 
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var output = JsonConvert.DeserializeObject<OutputData>(result);
                if (output != null && output.IsSucceed)
                {
                    Tenant = ((JArray)output.Data).ToObject<List<Tenant>>();
                }
            }
            return View(Tenant); 
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] Tenant dtForm)
        {
            if (ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(dtForm), Encoding.UTF8, "application/json");
                HttpClient client = await _api.InitialAsync();
                var result = await client.PostAsync("/api/Tenants", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
            return RedirectToAction(nameof(TenantView));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            List<Tenant> Tenant = new List<Tenant>();
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.GetAsync("/api/Tenants/" + id);
            var result = await res.Content.ReadAsStringAsync();
            var o = JObject.Parse(result);
            var data = JsonConvert.DeserializeObject<Tenant>(o.Root.ToString());
            return View(data);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, [Bind] Tenant dtForm)
        {
            if (ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(dtForm), Encoding.UTF8, "application/json");
                HttpClient client = await _api.InitialAsync();
                var result = await client.PutAsync("/api/Tenants/" + id, content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
            return RedirectToAction(nameof(TenantView));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            List<Tenant> Tenant = new List<Tenant>();
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.GetAsync("/api/Tenants/" + id);
            var result = await res.Content.ReadAsStringAsync();
            var o = JObject.Parse(result);
            var data = JsonConvert.DeserializeObject<Tenant>(o.Root.ToString());
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id)
        {
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.DeleteAsync("/api/Tenants/" + id);
            string resultContent = await res.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
            return RedirectToAction("TenantView");
        }

    }
}