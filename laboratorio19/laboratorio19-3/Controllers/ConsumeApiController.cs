using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace laboratorio19_3.Controllers
{
    public class ConsumeApiController : Controller
    {
        private static readonly string apiBaseUrl = "https://localhost:44365/api/"; 

        // GET: ConsumeApi/GetById/2
        public async Task<ActionResult> GetById(int id = 2)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiBaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Llamar al servicio que obtiene un dato específico
                    HttpResponseMessage response = await client.GetAsync($"values/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        var value = await response.Content.ReadAsAsync<string>();
                        ViewBag.Value = value;
                        ViewBag.Id = id;
                        ViewBag.Message = "Dato obtenido correctamente";
                    }
                    else
                    {
                        ViewBag.Message = $"Error: {response.StatusCode}";
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Error: {ex.Message}";
            }

            return View();
        }
    }
}