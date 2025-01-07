using IntegrationXML.Entities;
using IntegrationXML.Factories;
using IntegrationXML.Services;
using System;
using System.Threading.Tasks;

namespace IntegrationXML
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                // Inicializa a fábrica abstrata
                IAbstractFactory fabricaEntidade = new EntidadeAbstractFactory();

                // Cria as fábricas específicas para Aluno e Disciplina
                IEntidadeFactory alunoFactory = fabricaEntidade.CriarAlunoFactory();
                IEntidadeFactory disciplinaFactory = fabricaEntidade.CriarDisciplinaFactory();

                // Utiliza o singleton para buscar os dados dos alunos
                var cliente = HttpsClientSingleton.Instance;
                string alunosJson = await cliente.BuscarDadosAsync("alunos");

                // Cria um objeto Aluno a partir dos dados JSON
                Aluno aluno = (Aluno)alunoFactory.CriarEntidade(alunosJson);
                Console.WriteLine("Dados do Aluno:");
                Console.WriteLine(aluno);

                // Clona o objeto Aluno usando o padrão Prototype
                Aluno alunoClonado = aluno.Clone();
                alunoClonado.Nome = "Clone do Aluno"; // Fazemos uma pequena alteração no clone
                Console.WriteLine("\nDados do Aluno Clonado:");
                Console.WriteLine(alunoClonado);

                // Serializa o Aluno Original e o Clone para arquivos XML
                XmlHelper.SalvarEmXml(aluno, "AlunoOriginal.xml");
                XmlHelper.SalvarEmXml(alunoClonado, "AlunoClonado.xml");
                Console.WriteLine("Aluno salvo em XML com sucesso!");

                // Utiliza o singleton para buscar os dados das disciplinas
                string disciplinasJson = await cliente.BuscarDadosAsync("disciplinas");

                // Cria um objeto Disciplina a partir dos dados JSON
                Disciplina disciplina = (Disciplina)disciplinaFactory.CriarEntidade(disciplinasJson);
                Console.WriteLine("Dados da Disciplina:");
                Console.WriteLine(disciplina);

                // Clona o objeto Disciplina usando o padrão Prototype
                Disciplina disciplinaClonada = disciplina.Clone();
                disciplinaClonada.Nome = "Clone da Disciplina"; // Fazemos uma pequena alteração no clone
                Console.WriteLine("\nDados da Disciplina Clonada:");
                Console.WriteLine(disciplinaClonada);

                // Serializa a Disciplina Original e o Clone para arquivos XML
                XmlHelper.SalvarEmXml(disciplina, "DisciplinaOriginal.xml");
                XmlHelper.SalvarEmXml(disciplinaClonada, "DisciplinaClonada.xml");
                Console.WriteLine("Disciplina salva em XML com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}