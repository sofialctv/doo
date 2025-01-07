namespace IntegrationXML.Entities
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public Disciplina Clone()
        {
            return (Disciplina)MemberwiseClone(); // Cria uma cópia superficial do objeto
        }

        public override string ToString()
        {
            return $"Disciplina: {Nome}, Descrição: {Descricao}";
        }
    }
}
