Namespace Chart3D_Lesson3

    Public Class IrisData

        Private _Species As String, _SepalWidth As Double, _SepalLength As Double, _PetalWidth As Double, _PetalLength As Double

        Public Property Species As String
            Get
                Return _Species
            End Get

            Private Set(ByVal value As String)
                _Species = value
            End Set
        End Property

        Public Property SepalWidth As Double
            Get
                Return _SepalWidth
            End Get

            Private Set(ByVal value As Double)
                _SepalWidth = value
            End Set
        End Property

        Public Property SepalLength As Double
            Get
                Return _SepalLength
            End Get

            Private Set(ByVal value As Double)
                _SepalLength = value
            End Set
        End Property

        Public Property PetalWidth As Double
            Get
                Return _PetalWidth
            End Get

            Private Set(ByVal value As Double)
                _PetalWidth = value
            End Set
        End Property

        Public Property PetalLength As Double
            Get
                Return _PetalLength
            End Get

            Private Set(ByVal value As Double)
                _PetalLength = value
            End Set
        End Property

        Public Sub New(ByVal species As String, ByVal sepalWidth As Double, ByVal sepalLength As Double, ByVal petalWidth As Double, ByVal petalLength As Double)
            Me.Species = species
            Me.SepalWidth = sepalWidth
            Me.SepalLength = sepalLength
            Me.PetalWidth = petalWidth
            Me.PetalLength = petalLength
        End Sub
    End Class
End Namespace
