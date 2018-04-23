Imports System
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Resources
Imports System.Xml.Linq

Namespace Chart3D_Lesson3
    Public Class IrisesViewModel
        Public Property Irises() As ObservableCollection(Of IrisData)
        Public Sub New()
            Me.Irises = DataLoader.GetIrises("/Data/IrisDataSet.xml")
        End Sub
    End Class
    Friend NotInheritable Class DataLoader

        Private Sub New()
        End Sub

        Public Shared Function GetIrises(ByVal filepath As String) As ObservableCollection(Of IrisData)
            Dim irisDataSet As New ObservableCollection(Of IrisData)()
            Dim uri As New Uri(filepath, UriKind.RelativeOrAbsolute)
            Dim info As StreamResourceInfo = Application.GetResourceStream(uri)
            Dim document As XDocument = XDocument.Load(info.Stream)
            If document Is Nothing Then
                Return irisDataSet
            End If
            For Each element As XElement In document.Element("IrisDataSet").Elements("IrisData")
                Dim sepalLength As Double = Convert.ToDouble(element.Element("SepalLength").Value)
                Dim sepalWidth As Double = Convert.ToDouble(element.Element("SepalWidth").Value)
                Dim petalLength As Double = Convert.ToDouble(element.Element("PetalLength").Value)
                Dim petalWidth As Double = Convert.ToDouble(element.Element("PetalWidth").Value)
                Dim species As String = element.Element("Species").Value.ToString()
                irisDataSet.Add(New IrisData(species, sepalWidth, sepalLength, petalWidth, petalLength))
            Next element
            Return irisDataSet
        End Function
    End Class
End Namespace