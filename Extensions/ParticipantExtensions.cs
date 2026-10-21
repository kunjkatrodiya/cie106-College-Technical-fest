using cie478.Models;

namespace cie478.Extensions;

public static class ParticipantExtensions
{
    public static string GetRegistrationStatus(this Participant participant)
    {
        if (participant.IsRegistrationCompleted)
        {
            return "Confirmed";
        }

        return "Pending";
    }

    public static string GetFeeCategory(this Participant participant)
    {
        if (participant.RegistrationFee == null ||
            participant.RegistrationFee == 0)
        {
            return "Free Event";
        }
        else if (participant.RegistrationFee <= 500)
        {
            return "Standard Event";
        }
        else
        {
            return "Premium Event";
        }
    }
}