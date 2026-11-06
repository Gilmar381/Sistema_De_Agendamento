namespace Sistema_De_Agendamento.Model
{
    public class Profissional
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Especialidade { get; set; }
        public bool Ativo { get; set; }
    }
}
