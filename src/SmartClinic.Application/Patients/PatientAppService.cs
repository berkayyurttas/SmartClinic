using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SmartClinic.Patients;

public class PatientAppService : 
    CrudAppService<Patient, PatientDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePatientDto>, 
    IPatientAppService
{
    public PatientAppService(IRepository<Patient, Guid> repository) 
        : base(repository)
    {
    }

    // ABP'nin temel CreateAsync akışını bozmamak için en güvenli manuel eşleme:
    protected override async Task<Patient> MapToEntityAsync(CreateUpdatePatientDto createInput)
    {
        // 1. Nesneyi constructor ile oluşturuyoruz
        var patient = new Patient(
            GuidGenerator.Create(),
            createInput.Name,
            createInput.Surname,
            createInput.Complaint,
            (TriageStatus)createInput.Status
        );

        // 2. AdmissionDate'in dolduğundan emin oluyoruz (Patient.cs'de set; özelliği public olmalı)
        patient.AdmissionDate = Clock.Now;

        return await Task.FromResult(patient);
    }

    // OTOMATIK MAPPING HATALARINI ENGELLEMEK İÇİN BURAYI DA EZİYORUZ
    protected override Task MapToEntityAsync(CreateUpdatePatientDto updateInput, Patient entity)
    {
        entity.Name = updateInput.Name;
        entity.Surname = updateInput.Surname;
        entity.Complaint = updateInput.Complaint;
        entity.Status = (TriageStatus)updateInput.Status;
        
        return Task.CompletedTask;
    }
}