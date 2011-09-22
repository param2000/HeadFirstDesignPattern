Namespace CompositionRocks
    Public Class CanadianDuck
        Private _canSwim As ICanSwim
        Private _canQuack As ICanQuack

        Public Sub New(ByVal canSwim As ICanSwim, ByVal canQuack As ICanQuack)
            _canSwim = canSwim
            _canQuack = canQuack
        End Sub
        Public Sub Quack()
            _canQuack.Quack()
        End Sub
        Public Sub Swim()
            _canSwim.Swim()
        End Sub

        Public Property CanSwim() As ICanSwim
            Get
                Return _canSwim
            End Get
            Set (ByVal value As ICanSwim)
                _canSwim = value
            End Set
        End Property

        Public Property CanQuack() As ICanQuack
            Get
                Return _canQuack
            End Get
            Set (ByVal value As ICanQuack)
                _canQuack = value
            End Set
        End Property

    End Class
End Namespace