namespace cie478.Models;

public class Participant
{
    public int ParticipantId { get; set; }

    public string ParticipantName { get; set; } = "";

    public string Email { get; set; } = "";

    public string Department { get; set; } = "";

    public int Year { get; set; }

    public string EventName { get; set; } = "";

    public bool IsTeamEvent { get; set; }

    public decimal? RegistrationFee { get; set; }

    public bool IsRegistrationCompleted { get; set; }
}