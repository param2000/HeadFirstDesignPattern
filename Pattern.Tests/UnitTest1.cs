using System.Security.Principal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternsCore.Security;
using Rhino.Mocks;

namespace Pattern.Tests
{


    [TestClass()]
    public class RhinoMocksAtPlay
    {


        [TestMethod()]
        public
        void TestMethod1()
        {
            var mrepo = new MockRepository();

            var user = mrepo.DynamicMock<IPrincipal>();
            var permissionChecker = new CheckUserPermissions();
            using (mrepo.Record())
            {
                SetupResult.For(user.IsInRole("test")).Return(true);
            }

            using (mrepo.Playback())
            {
                Assert.IsTrue(permissionChecker.HaveManagerRole(user));
            }
        }
    }
}


