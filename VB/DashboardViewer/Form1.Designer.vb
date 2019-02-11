Namespace Viewer
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dashboardViewer1
            ' 
            Me.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(236)))), (CInt((CByte(239)))))
            Me.dashboardViewer1.Appearance.Options.UseBackColor = True
            Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardViewer1.Location = New System.Drawing.Point(0, 49)
            Me.dashboardViewer1.Name = "Viewer1"
            Me.dashboardViewer1.Size = New System.Drawing.Size(1190, 546)
            Me.dashboardViewer1.TabIndex = 0
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 1
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Size = New System.Drawing.Size(1190, 49)
            ' 
            ' Form1
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1190, 595)
            Me.Controls.Add(Me.dashboardViewer1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Dashboard Viewer"
            CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    End Class
End Namespace