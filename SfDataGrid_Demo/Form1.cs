using Syncfusion.Data;
using Syncfusion.WinForms.Core.Utils;
using Syncfusion.WinForms.DataGrid;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        OrderInfoCollection _orderInfos;
        public Form1()
        {
            InitializeComponent();
            _orderInfos = new OrderInfoCollection();
            sfDataPager1.AllowOnDemandPaging = true;
            sfDataPager1.PageCount = 6;
            sfDataPager1.PageSize = 10;
            sfDataPager1.OnDemandLoading += SfDataPager1_OnDemandLoading;
        }


        BusyIndicator BusyIndicator = new BusyIndicator();
        private async void SfDataPager1_OnDemandLoading(object? sender, Syncfusion.WinForms.DataPager.Events.OnDemandLoadingEventArgs e)
        {
            var results1 = await _orderInfos.GenerateOrders();
            sfDataPager1.LoadDynamicData(e.StartRowIndex, results1.Skip(e.StartRowIndex).Take(e.PageSize));
            BusyIndicator.Show(this.sfDataGrid1.TableControl);
            Thread.Sleep(1000);
            if (sfDataGrid1.DataSource == null)
                sfDataGrid1.DataSource = sfDataPager1.PagedSource;
            (sfDataPager1.PagedSource as PagedCollectionView).Refresh();
            BusyIndicator.Hide();
        }
    }
}
