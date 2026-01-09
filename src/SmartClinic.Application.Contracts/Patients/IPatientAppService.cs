using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SmartClinic.Patients;

public interface IPatientAppService : 
    ICrudAppService<
        PatientDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdatePatientDto>
{
    // İleride buraya "Acil hastaları getir" gibi özel metodlar ekleyeceğiz.
}