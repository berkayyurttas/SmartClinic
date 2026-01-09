using SmartClinic.Samples;
using Xunit;

namespace SmartClinic.EntityFrameworkCore.Applications;

[Collection(SmartClinicTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SmartClinicEntityFrameworkCoreTestModule>
{

}
