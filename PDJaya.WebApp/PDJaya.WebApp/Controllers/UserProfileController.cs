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
    public class UserProfileController : Controller
    {
        HelperClientHttp _api = new HelperClientHttp(); //Check di Helper fungsi
        public async Task<IActionResult> Index()
        {
            List<UserProfile> UserProfile = new List<UserProfile>();
            HttpClient client = await _api.InitialAsync(); //dari Global Variable
            HttpResponseMessage res = await client.GetAsync("/api/UserProfiles"); //URL GET DATA ke UserProfile check di https://pdjayaservice.azurewebsites.net
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var output = JsonConvert.DeserializeObject<OutputData>(result); //Output data di Helper fungsi untuk menampung data sementara
                if (output != null && output.IsSucceed)
                {
                    UserProfile = ((JArray)output.Data).ToObject<List<UserProfile>>(); // Pass data dari output.Data ke list userprofile class
                }
            }
            return View(UserProfile); //menampilkan data
        }

        public IActionResult CreateUserProfile()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] UserProfile dtForm)
        {
            if (ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(dtForm), Encoding.UTF8, "application/json");
                HttpClient client = await _api.InitialAsync();
                var result = await client.PostAsync("/api/UserProfiles", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            List<UserProfile> UserProfile = new List<UserProfile>();
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.GetAsync("/api/UserProfiles/" + id);
            var result = await res.Content.ReadAsStringAsync();
            var o = JObject.Parse(result);
            var data = JsonConvert.DeserializeObject<UserProfile>(o.Root.ToString());
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id)
        {
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.DeleteAsync("/api/UserProfiles/" + id);
            string resultContent = await res.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
            return RedirectToAction("Index");
        }
    }
}