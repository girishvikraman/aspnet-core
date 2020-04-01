using EYVAPP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EYVAPP.Permissions
{
    public class EYVAPPPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(EYVAPPPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(EYVAPPPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<EYVAPPResource>(name);
        }
    }
}
