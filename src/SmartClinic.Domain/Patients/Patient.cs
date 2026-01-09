using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SmartClinic.Patients;

public class Patient : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Complaint { get; set; }
    // int yerine Enum kullanıyoruz ki tip uyuşmazlığı olmasın
    public TriageStatus Status { get; set; } 
    public DateTime AdmissionDate { get; set; }

    // KRİTİK DEĞİŞİKLİK: 'protected' olan yeri 'public' yaptık
    public Patient() { }

    public Patient(Guid id, string name, string surname, string complaint, TriageStatus status)
        : base(id)
    {
        Name = name;
        Surname = surname;
        Complaint = complaint;
        Status = status;
        AdmissionDate = DateTime.Now;
    }
}