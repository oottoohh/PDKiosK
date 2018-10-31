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
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.GetAsync("/api/UserProfiles/" + id);
            var result = await res.Content.ReadAsStringAsync();
            UserProfile[] userProfiles= JsonConvert.DeserializeObject<UserProfile[]>(result);            
            return View(userProfiles);
        }

        [HttpPost, ActionName("DeleteItem")]
        public async Task<ActionResult> DeleteAsync(int? id)
        {
            HttpClient client = await _api.InitialAsync();
            HttpResponseMessage res = await client.DeleteAsync("/api/UserProfiles/" + id);
            string resultContent = await res.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
            return RedirectToAction("Index");
        }
    }
}