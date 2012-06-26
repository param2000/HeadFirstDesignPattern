using System.Security.Principal;
namespace PatternsCore.Security
{
    public class CheckUserPermissions
    {
        public bool HaveManagerRole(IPrincipal user)
        {
            return user.IsInRole("test");
        }
    }


}
