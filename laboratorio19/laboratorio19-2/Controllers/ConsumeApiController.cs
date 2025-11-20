using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace laboratorio19_2.Controllers
{
    public class ConsumeApiController : Controller
    {
        private static readonly string apiBaseUrl = "https://localhost:44365/api/";

        // GET: ConsumeApi/GetAll
        public async Task<ActionResult> GetAll()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiBaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    // Llamar al servicio que obtiene todos los datos
                    HttpResponseMessage response = await client.GetAsync("values");

                    if (response.IsSuccessStatusCode)
                    {
                        var values = await response.Content.ReadAsAsync<string[]>();
                        ViewBag.Values = values;
                        ViewBag.Message = "Datos obtenidos correctamente";
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