namespace Sistema_De_Agendamento.Model
{
    public class Agenda
    {
        public int Id { get; set; }
        public int ProfissionalId { get; set; }
        public DateTime DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public bool Ativo { get; set; }
    }
}
