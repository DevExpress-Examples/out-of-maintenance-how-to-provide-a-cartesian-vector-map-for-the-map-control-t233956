Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace CartesianMap
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub VectorLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            mapControl.ZoomToFitLayerItems()
        End Sub
    End Class
End Namespace
