Imports System.Security.Principal

Public Class CheckUserPermissions
    Public Function HaveManagerRole(ByVal user As IPrincipal) As Boolean
        Return user.IsInRole("test")
    End Function
End Class
