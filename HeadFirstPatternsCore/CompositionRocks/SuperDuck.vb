Namespace CompositionRocks
    Public Class SuperDuck
        Private _canfly As ICanFly
        Private _canSwim As ICanSwim
        Private _canquack As ICanQuack

        'Note I cant function without these objects[these objects are must for me ]
        'note [Who Implements it i dont care
        Public Sub New(ByVal canfly As ICanFly, ByVal canSwim As ICanSwim, ByVal canquack As ICanQuack)
            _canfly = canfly
            _canSwim = canSwim
            _canquack = canquack
        End Sub

        'Note Can Chnage at Runtime
        Public Property Canfly() As ICanFly
            Get
                Return _canfly
            End Get
            Set (ByVal value As ICanFly)
                _canfly = value
            End Set
        End Property
        Public Property CanSwim() As ICanSwim
            Get
                Return _canSwim
            End Get
            Set(ByVal value As ICanSwim)
                _canSwim = value
            End Set
        End Property
        Public Property Canquack() As ICanQuack
            Get
                Return _canquack
            End Get
            Set(ByVal value As ICanQuack)
                _canquack = value
            End Set
        End Property

        'Note Behaviors
        Public Sub Quack()
            _canQuack.Quack()
        End Sub
        Public Sub Swim()
            _canSwim.Swim()
        End Sub
        Public Sub Fly()
            _canfly.Fly()
        End Sub

    End Class
End NameSpace