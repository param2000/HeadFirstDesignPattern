Namespace CompositionRocks
    public Class CanQuack
        Implements ICanQuack

        Public Sub Quack() Implements ICanQuack.Quack
            My.Computer.Audio.Play("C:\Projects\HeadFirstDesignPattern\Sounds\Quack.wav")
        End Sub
    End Class
End NameSpace