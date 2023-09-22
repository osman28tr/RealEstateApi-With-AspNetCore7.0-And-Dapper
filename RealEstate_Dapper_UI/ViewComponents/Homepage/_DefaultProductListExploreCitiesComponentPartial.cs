using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.PopularLocations;

namespace RealEstate_Dapper_UI.ViewComponents.Homepage
{
    public class _DefaultProductListExploreCitiesComponentPartial:ViewComponent
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultProductListExploreCitiesComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:60224/api/PopularLocations/");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultPopularLocationDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
