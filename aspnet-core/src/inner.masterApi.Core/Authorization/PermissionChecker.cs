using Abp.Authorization;
using inner.masterApi.Authorization.Roles;
using inner.masterApi.Authorization.Users;

namespace inner.masterApi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
