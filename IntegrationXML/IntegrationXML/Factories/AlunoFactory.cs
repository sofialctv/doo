using IntegrationXML.Entities;
using IntegrationXML.Factories;
using Newtonsoft.Json;

namespace IntegrationXML.Factories
{
    public class AlunoFactory : IEntidadeFactory
    {
        public object CriarEntidade(string jsonData)
        {
            // Desserializa o JSON em um objeto Aluno
            return JsonConvert.DeserializeObject<Aluno>(jsonData);
        }
    }
}