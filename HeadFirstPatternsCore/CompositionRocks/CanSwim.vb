Namespace CompositionRocks
    Public Class CanSwim
        Implements ICanSwim

        Public Sub Swim() Implements ICanSwim.Swim
            MsgBox("I am Swimming")
        End Sub
    End Class
End Namespace