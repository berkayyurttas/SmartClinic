using System;
using Volo.Abp.Application.Dtos;

namespace SmartClinic.Patients;

public class PatientDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Complaint { get; set; }
    public TriageStatus Status { get; set; } // Bu satır hataya sebep oluyordu
    public DateTime AdmissionDate { get; set; }
}