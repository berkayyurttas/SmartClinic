using SmartClinic.Samples;
using Xunit;

namespace SmartClinic.EntityFrameworkCore.Domains;

[Collection(SmartClinicTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SmartClinicEntityFrameworkCoreTestModule>
{

}
