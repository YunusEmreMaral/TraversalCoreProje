//using Microsoft.AspNetCore.Mvc;

//using System.Net.Http;
//using System;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using TraversalCoreProje.Areas.Admin.Models;
//using Microsoft.AspNetCore.Authorization;
//using DocumentFormat.OpenXml.Bibliography;
//using DocumentFormat.OpenXml.Wordprocessing;

//namespace TraversalCoreProje.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    [AllowAnonymous]
//    public class BookingHotelSearchController : Controller
//    {
//        [HttpPost]
//        public async Task<IActionResult> GetCityDestID(string cityName)
//        {
//            var cityInfo = JsonConvert.DeserializeObject<CityInfo>(body);
//            var cityId = cityInfo?.result?.first?.destination_id;

//            var client = new HttpClient();
//            var request = new HttpRequestMessage
//            {
//                Method = HttpMethod.Get,
//                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=tr&name={cityName}"),
//                Headers =
//        {
//            { "X-RapidAPI-Key", "aac6c9f9e2mshb4fa241b2cbb6bep169154jsn676f519678d7" },
//            { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
//        },
//            };

//            using (var response = await client.SendAsync(request))
//            {
//                response.EnsureSuccessStatusCode();
//                var body = await response.Content.ReadAsStringAsync();
//                var cityInfo = JsonConvert.DeserializeObject<city>(body);

//                // Şehir bilgisinden şehir ID'sini al
//                var cityId = cityInfo?.result?.first?.destination_id;

//                // Şehir ID'siyle otel araması yapmak için Index action methoduna yönlendir
//                return RedirectToAction("Index", new { cityId });
//            }
//        }

//        public async Task<IActionResult> Index(int cityId)
//        {
//            if (cityId == 0)
//            {
//                // Şehir ID'si yoksa hata mesajı göster veya başka bir işlem yap
//                return NotFound();
//            }

//            var client = new HttpClient();
//            var request = new HttpRequestMessage
//            {
//                Method = HttpMethod.Get,
//                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/search?dest_id={cityId}&locale=tr"),
//                Headers =
//        {
//            { "X-RapidAPI-Key", "aac6c9f9e2mshb4fa241b2cbb6bep169154jsn676f519678d7" },
//            { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
//        },
//            };

//            using (var response = await client.SendAsync(request))
//            {
//                response.EnsureSuccessStatusCode();
//                var body = await response.Content.ReadAsStringAsync();
//                var hotelSearchResult = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);

//                // Otelleri göstermek için View'e modeli geçir
//                return View(hotelSearchResult.result);
//            }
//        }

//    }
//}

