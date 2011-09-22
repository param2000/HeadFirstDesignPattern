Namespace CompositionRocks
    Public Class ComposistionDuckCollections
        Private ReadOnly _ducks As IList(Of DuckValuePairs)

        Public Sub New()
            _ducks = New List(Of DuckValuePairs)()
            _ducks.Add(New DuckValuePairs("Mallard Duck", GetType(SuperDuck)))
            _ducks.Add(New DuckValuePairs("Rubber Duck", GetType(RubberDuck)))
        End Sub

        Public ReadOnly Property Ducks() As IList(Of DuckValuePairs)
            Get
                Return _ducks
            End Get
        End Property
    End Class
End Namespace