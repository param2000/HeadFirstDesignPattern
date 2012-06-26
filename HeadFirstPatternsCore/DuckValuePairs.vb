Imports Castle.Windsor

Public Class DuckValuePairs
    Public Property Name() As String
    Public Property Value() As Type

    Public Sub New(ByVal name As String, ByVal value As Type)
        _Name = name
        _Value = value
    End Sub
End Class



Public Class Bob
    Implements IContainerAccessor
    Private _container As IWindsorContainer

    Public Sub New()
        _container = New WindsorContainer()
    End Sub

    Public ReadOnly Property Container() As IWindsorContainer Implements IContainerAccessor.Container
        Get
            Return _container
        End Get
    End Property

    
End Class