Namespace CompositionRocks

    Public Class CanFly
        Implements ICanFly

        Public Sub Fly() Implements CompositionRocks.ICanFly.Fly
            MsgBox("I am flying")
        End Sub
    End Class
End Namespace