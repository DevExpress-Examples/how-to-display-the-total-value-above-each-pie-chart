Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.DashboardWin
Imports DevExpress.XtraCharts

Namespace TotalsInChartsExample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            Me.dashboardViewer1.DashboardItemControlUpdated += AddressOf Viewer_DashboardItemControlUpdated
            dashboardViewer1.CalculateHiddenTotals = True
            dashboardViewer1.DashboardSource = GetType(Dashboards.Dashboard1)
        End Sub

        Private Sub Viewer_DashboardItemControlUpdated(ByVal sender As Object, ByVal e As DashboardItemControlEventArgs)
            If e.DashboardItemName Is "pieDashboardItem1" Then
                Dim viewer = CType(sender, DashboardViewer)
                Dim chart = e.ChartControl
                Dim data = viewer.GetItemData(e.DashboardItemName)
                Dim measure = data.GetMeasures()(0)
                For Each series As Series In chart.Series
                    Dim axisPoint = TryCast(series.Tag, AxisPoint)
                    If axisPoint IsNot Nothing Then
                        Dim total = data.GetSlice(axisPoint).GetValue(measure).DisplayText
                        Dim view = TryCast(series.View, PieSeriesView)
                        If view IsNot Nothing Then view.Titles(0).Text = String.Format("{0} - {1}", series.Name, total)
                    End If
                Next
            End If
        End Sub
    End Class
End Namespace
