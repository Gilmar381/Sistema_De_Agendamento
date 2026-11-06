namespace Sistema_De_Agendamento.Model
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int DuracaoMinutos { get; set; } // Duração em minutos
        public bool Ativo { get; set; }
    }
}
