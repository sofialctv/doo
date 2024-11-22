using System;
using System.Net.Http;
using System.Net.Http.Headers;

public class ApiClient
{
    private static readonly HttpClient _httpClient = new HttpClient();
    
    // Lazy garante inicialização tardia
    private static readonly Lazy<ApiClient> _instance = new Lazy<ApiClient>(() => new ApiClient());

    private ApiClient()
    {
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")); 
        _httpClient.DefaultRequestHeaders.Add("User-Agent", ".NET Escola Web Service Client");
    }
    public static ApiClient Instance => _instance.Value;
   
    // Acesso ao HTTP
    public HttpClient HttpClient => _httpClient;

    // URL base
    public void SetBaseAddress(string baseAddress)
    {
        if (_httpClient.BaseAddress == null)
        {
            _httpClient.BaseAddress = new Uri(baseAddress);
        }
    }
}