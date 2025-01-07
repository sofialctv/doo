namespace IntegrationXML.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }

        // Implementação do método Clone
        public Aluno Clone()
        {
            return (Aluno)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Aluno: {Nome}, Endereço: {Endereco}";
        }
    }
}
