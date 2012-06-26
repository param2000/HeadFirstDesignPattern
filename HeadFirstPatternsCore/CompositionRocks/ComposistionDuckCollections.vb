Namespace CompositionRocks
    Public Class ComposistionDuckCollections
        Private ReadOnly _ducks As IList(Of DuckValuePairs)

        Public Sub New()
            _ducks = New List(Of DuckValuePairs)()
            _ducks.Add(New DuckValuePairs("Super Duck", GetType(MallardDuck)))
            _ducks.Add(New DuckValuePairs("Rubber Duck", GetType(RubberDuck)))
            _ducks.Add(New DuckValuePairs("Canadian Duck", GetType(CanadianDuck)))
        End Sub

        Public ReadOnly Property Ducks() As IList(Of DuckValuePairs)
            Get
                Return _ducks
            End Get
        End Property
    End Class
End Namespace