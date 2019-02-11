using DevExpress.DashboardCommon.ViewerData;
using DevExpress.DashboardWin;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using System.Linq;

namespace Viewer {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();

            dashboardViewer1.DashboardItemControlUpdated += Viewer_DashboardItemControlUpdated;
            dashboardViewer1.CalculateHiddenTotals = true;
            dashboardViewer1.LoadDashboard(@"..\..\Dashboards\dashboard1.xml");
        }

        private void Viewer_DashboardItemControlUpdated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e) {
            if (e.DashboardItemName == "pieDashboardItem1") {
                var viewer = (DashboardViewer)sender;
                var chart = e.ChartControl;

                var data = viewer.GetItemData(e.DashboardItemName);
                var measure = data.GetMeasures()[0];

                foreach (Series series in chart.Series) {
                    var axisPoint = series.Tag as AxisPoint;
                    if (axisPoint != null) {
                        var total = data.GetSlice(axisPoint).GetValue(measure).DisplayText;
                        var view = series.View as PieSeriesView;
                        if (view != null)
                            view.Titles[0].Text = string.Format("{0} - {1}", series.Name, total);
                    }
                }
            }
        }
    }
}
