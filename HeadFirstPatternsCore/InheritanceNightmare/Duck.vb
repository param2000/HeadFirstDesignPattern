Namespace InheritanceNightmare
    Public Class Duck

        Public Sub Quack()
            My.Computer.Audio.Play("C:\Projects\HeadFirstDesignPattern\Sounds\Quack.wav")
        End Sub
        Public Sub Fly()
            MsgBox("I am flying")
        End Sub

        Public Sub Swim()
            MsgBox("i am swimming ")
        End Sub
    End Class
End Namespace