namespace BlazorECommerce.Client.Util
{
	public class PublicHttpClient
	{
		public HttpClient Http { get; set; }

		public PublicHttpClient(HttpClient httpClient)
		{
			Http = httpClient;
		}
	}
}
