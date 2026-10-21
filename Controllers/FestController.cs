using Microsoft.AspNetCore.Mvc;

namespace cie478.Controllers;

public class FestController : Controller
{
    // Temporary collection for storing participants
    private static readonly List<Participant> participants = new();

    // Display all registered participants
    public IActionResult Index()
    {
        return View(participants);
    }

    // Display registration form
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    // Handle registration form submission
    [HttpPost]
    public IActionResult Register(Participant participant)
    {
        if (!ModelState.IsValid)
        {
            return View(participant);
        }

        // Generate Participant ID
        participant.ParticipantId = participants.Count + 1;

        // Mark registration as completed
        participant.IsRegistrationCompleted = true;

        // Automatically assign registration fee based on selected event
        participant.RegistrationFee = participant.EventName switch
        {
            "Hackathon" => 500,
            "Code Clash" => 300,
            "Robo Race" => 600,
            "Web Design" => 0,
            _ => 0
        };

        // Store participant temporarily
        participants.Add(participant);

        // Redirect to participant list
        return RedirectToAction("Index");
    }

    // Display participant details
    public IActionResult Details(int id)
    {
        var participant = participants
            .FirstOrDefault(p => p.ParticipantId == id);

        if (participant == null)
        {
            return NotFound();
        }

        return View(participant);
    }

    // Display welcome page
    public IActionResult Welcome()
    {
        return View();
    }
}