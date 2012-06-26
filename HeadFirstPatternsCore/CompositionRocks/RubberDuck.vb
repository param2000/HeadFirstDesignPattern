Namespace CompositionRocks
    Public Class RubberDuck
        Private _canSwim As ICanSwim

        Public Sub New(ByVal canSwim As ICanSwim)
            _canSwim = canSwim
        End Sub

        Public Property CanSwim() As ICanSwim
            Get
                Return _canSwim
            End Get
            Set (ByVal value As ICanSwim)
                _canSwim = value
            End Set
        End Property

        Public Sub Swim()
            _canSwim.Swim()
        End Sub
    End Class
End NameSpace