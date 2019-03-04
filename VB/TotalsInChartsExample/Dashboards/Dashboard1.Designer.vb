Namespace TotalsInChartsExample.Dashboards
	Partial Public Class Dashboard1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
			Me.dashboardExcelDataSource1 = New DevExpress.DashboardCommon.DashboardExcelDataSource()
			DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' pieDashboardItem1
			' 
			dimension1.DataMember = "Category"
			Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
			measure1.DataMember = "RevenueQTD (Sum)"
			dimension2.DataMember = "State"
			Me.pieDashboardItem1.DataItemRepository.Clear()
			Me.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.pieDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
			Me.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem2")
			Me.pieDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.pieDashboardItem1.Name = "Pies 1"
			Me.pieDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.pieDashboardItem1.ShowCaption = True
			Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
			' 
			' dashboardExcelDataSource1
			' 
			Me.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1"
			Me.dashboardExcelDataSource1.FileName = "|DataDirectory|\Data\Sales.xlsx"
			Me.dashboardExcelDataSource1.Name = "Excel Data Source 1"
			Me.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "Category"
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Product"
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "State"
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "UnitsSoldYTD (Sum)"
			fieldInfo4.Type = GetType(Double)
			fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)"
			fieldInfo5.Type = GetType(Double)
			fieldInfo6.Name = "RevenueQTD (Sum)"
			fieldInfo6.Type = GetType(Double)
			fieldInfo7.Name = "RevenueQTDTarget (Sum)"
			fieldInfo7.Type = GetType(Double)
			fieldInfo8.Name = "RevenueYTD (Sum)"
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "RevenueYTDTarget (Sum)"
			fieldInfo9.Type = GetType(Double)
			Me.dashboardExcelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9})
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetName = "Sheet1"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' Dashboard1
			' 
			Me.CurrencyCultureName = Nothing
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExcelDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pieDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.pieDashboardItem1
			dashboardLayoutItem1.Weight = 42.646071188717258R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Sales by State - Totals"
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pieDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem
		Private dashboardExcelDataSource1 As DevExpress.DashboardCommon.DashboardExcelDataSource
	End Class
End Namespace
