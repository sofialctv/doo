using IntegrationXML.Entities;
using IntegrationXML.Factories;
using Newtonsoft.Json;

public class DisciplinaFactory : IEntidadeFactory
{
    public object CriarEntidade(string jsonData)
    {
        // Desserializa o JSON em um objeto Disciplina
        return JsonConvert.DeserializeObject<Disciplina>(jsonData);
    }
}