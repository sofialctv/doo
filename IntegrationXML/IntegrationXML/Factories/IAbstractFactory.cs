namespace IntegrationXML.Factories
{
    public interface IAbstractFactory
    {
        IEntidadeFactory CriarAlunoFactory();
        IEntidadeFactory CriarDisciplinaFactory();
    }

}
