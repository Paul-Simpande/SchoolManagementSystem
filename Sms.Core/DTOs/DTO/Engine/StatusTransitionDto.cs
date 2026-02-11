namespace Sms.Core.DTOs.DTO.Engine;

public class StatusTransitionDto
{
    public int TransitionId { get; set; }

    public int DomainId { get; set; }
    public int FromStatusId { get; set; }
    public int ToStatusId { get; set; }

    public bool RequiresApproval { get; set; }
    public bool IsTerminal { get; set; }

    public DateTime CreatedAt { get; set; }
}
