namespace IntegrationXML.Factories
{
    public interface IEntidadeFactory
    {
        // Método para criar uma entidade a partir de uma string JSON
        object CriarEntidade(string jsonData);
    }
}