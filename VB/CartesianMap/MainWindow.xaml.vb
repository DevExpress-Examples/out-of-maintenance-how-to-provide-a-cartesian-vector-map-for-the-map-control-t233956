Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace CartesianMap

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub VectorLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            Me.mapControl.ZoomToFitLayerItems()
        End Sub
    End Class
End Namespace
