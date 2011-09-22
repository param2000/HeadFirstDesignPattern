Imports System.Security.Principal
Imports HeadFirstPatternsCore
Imports Rhino.Mocks

<TestClass()>
Public Class RhinoMocksAtPlay

    <TestMethod()>
    Public Sub TestMethod1()
        Dim mrepo = New MockRepository()

        Dim user As IPrincipal = mrepo.DynamicMock(Of IPrincipal)()
        Dim permissionChecker = New CheckUserPermissions
        Using (mrepo.Record)
            SetupResult.For(user.IsInRole("test")).Return(True)
        End Using
        Using (mrepo.Playback())
            Assert.IsTrue(permissionChecker.HaveManagerRole(user))
        End Using

    End Sub

End Class