using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IntegrationXML.Services
{
    public class HttpsClientSingleton
    {
        // Inicialização Lazy da instância, o que vai garantir que o objeto seja instanciado apenas quando for realmente necessário de forma thread-safe
        private static readonly Lazy<HttpsClientSingleton> _instance =
            new Lazy<HttpsClientSingleton>(() => new HttpsClientSingleton());

        // HTTP client que será utilizado para interagir com o web service
        private readonly HttpClient _httpClient;

        // Construtor privado que garante que não sejam criadas novas instâncias da classa
        private HttpsClientSingleton()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:3000/");
        }
        public static HttpsClientSingleton Instance => _instance.Value;

        // Método que retorna dados do web service
        public async Task<string> BuscarDadosAsync(string endpoint)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception("Erro ao acessar o web service.");
            }
        }
    }
}