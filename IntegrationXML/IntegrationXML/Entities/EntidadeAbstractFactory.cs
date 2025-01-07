using IntegrationXML.Factories;

namespace IntegrationXML.Entities
{
    public class EntidadeAbstractFactory : IAbstractFactory
    {
        public IEntidadeFactory CriarAlunoFactory()
        {
            return new AlunoFactory();
        }

        public IEntidadeFactory CriarDisciplinaFactory()
        {
            return new DisciplinaFactory();
        }
    }

}
