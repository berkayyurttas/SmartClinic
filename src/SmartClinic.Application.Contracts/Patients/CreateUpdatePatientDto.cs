using System;
using System.ComponentModel.DataAnnotations;

namespace SmartClinic.Patients;

public class CreateUpdatePatientDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; }

    [Required]
    [StringLength(128)]
    public string Surname { get; set; }

    [StringLength(512)]
    public string Complaint { get; set; }

    public TriageStatus Status { get; set; } = TriageStatus.Green;
}