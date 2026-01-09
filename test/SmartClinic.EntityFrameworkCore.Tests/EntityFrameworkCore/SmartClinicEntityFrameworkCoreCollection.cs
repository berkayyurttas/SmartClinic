using Xunit;

namespace SmartClinic.EntityFrameworkCore;

[CollectionDefinition(SmartClinicTestConsts.CollectionDefinitionName)]
public class SmartClinicEntityFrameworkCoreCollection : ICollectionFixture<SmartClinicEntityFrameworkCoreFixture>
{

}
