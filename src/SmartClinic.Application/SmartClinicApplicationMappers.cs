using Riok.Mapperly.Abstractions;
using SmartClinic.Patients;
using Volo.Abp.Mapperly;

namespace SmartClinic;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class SmartClinicApplicationMappers : MapperBase<Patient, PatientDto>
{
    public override partial PatientDto Map(Patient source);
    public override partial void Map(Patient source, PatientDto destination);

    // DTO'yu Entity'ye çevirmek için bu satırı EKLE:
    public partial Patient Map(CreateUpdatePatientDto source);
}