using Abp.Authorization;
using zyGIS.Authorization.Roles;
using zyGIS.Authorization.Users;

namespace zyGIS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
