using SmartClinic.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace SmartClinic.Permissions;

public class SmartClinicPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SmartClinicPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(SmartClinicPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SmartClinicResource>(name);
    }
}
