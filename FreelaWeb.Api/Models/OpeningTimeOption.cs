namespace FreelaWeb.Api.Models
{
    public class OpeningTimeOption
    {
        //Classe criada para representar as opções de horário de abertura que está no appsettings.json
        public TimeSpan StartAt { get; set; }
        public TimeSpan FinishAt { get; set; }
    }
}
