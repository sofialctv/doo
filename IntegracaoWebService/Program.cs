using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // URL base
        var clientSingleton = ApiClient.Instance;
        clientSingleton.SetBaseAddress("http://localhost:3000/");

        // Processando as requisições ao web service
        await ProcessRepositoriesAsync(clientSingleton.HttpClient);
    }

    static async Task ProcessRepositoriesAsync(HttpClient client)
    {
        // Consumo de dados do web service
        var response = await client.GetAsync("alunos"); // Exemplo de chamada à API de alunos
        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();
            Console.WriteLine(data);
        }
    }
}
