Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.DashboardWin
Imports DevExpress.XtraBars
Imports DevExpress.XtraCharts
Imports System.Linq

Namespace Viewer
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()

            AddHandler dashboardViewer1.DashboardItemControlUpdated, AddressOf Viewer_DashboardItemControlUpdated
            dashboardViewer1.CalculateHiddenTotals = True
            dashboardViewer1.LoadDashboard("..\..\Dashboards\dashboard1.xml")
        End Sub

        Private Sub Viewer_DashboardItemControlUpdated(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs)
            If e.DashboardItemName = "pieDashboardItem1" Then
                Dim viewer = DirectCast(sender, DashboardViewer)
                Dim chart = e.ChartControl

                Dim data = viewer.GetItemData(e.DashboardItemName)
                Dim measure = data.GetMeasures()(0)

                For Each series As Series In chart.Series
                    Dim axisPoint = TryCast(series.Tag, AxisPoint)
                    If axisPoint IsNot Nothing Then
                        Dim total = data.GetSlice(axisPoint).GetValue(measure).DisplayText
                        Dim view = TryCast(series.View, PieSeriesView)
                        If view IsNot Nothing Then
                            view.Titles(0).Text = String.Format("{0} - {1}", series.Name, total)
                        End If
                    End If
                Next series
            End If
        End Sub
    End Class
End Namespace
