using config.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace config.Permissions;

public class configPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(configPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(configPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<configResource>(name);
    }
}
