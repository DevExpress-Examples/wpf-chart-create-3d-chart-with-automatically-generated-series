Namespace Chart3D_Lesson3
    Public Class IrisData
        Private privateSpecies As String
        Public Property Species() As String
            Get
                Return privateSpecies
            End Get
            Private Set(ByVal value As String)
                privateSpecies = value
            End Set
        End Property
        Private privateSepalWidth As Double
        Public Property SepalWidth() As Double
            Get
                Return privateSepalWidth
            End Get
            Private Set(ByVal value As Double)
                privateSepalWidth = value
            End Set
        End Property
        Private privateSepalLength As Double
        Public Property SepalLength() As Double
            Get
                Return privateSepalLength
            End Get
            Private Set(ByVal value As Double)
                privateSepalLength = value
            End Set
        End Property
        Private privatePetalWidth As Double
        Public Property PetalWidth() As Double
            Get
                Return privatePetalWidth
            End Get
            Private Set(ByVal value As Double)
                privatePetalWidth = value
            End Set
        End Property
        Private privatePetalLength As Double
        Public Property PetalLength() As Double
            Get
                Return privatePetalLength
            End Get
            Private Set(ByVal value As Double)
                privatePetalLength = value
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