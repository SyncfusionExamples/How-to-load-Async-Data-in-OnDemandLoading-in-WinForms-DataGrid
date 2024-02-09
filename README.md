# How to load Async Data in OnDemandLoading in WinForms DataGrid

In [WinForms DataGrid](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html) (SfDataGrid), [SfDataPager.OnDemandLoading](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataPager.SfDataPager.html#Syncfusion_WinForms_DataPager_SfDataPager_OnDemandLoading) event does not support the async and await processes. Therefore, if you are using the await keyword to call a method, it may not work properly. However, you can overcome this issue by setting the [sfDataGrid.DataSource](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_DataSource) in the OnDemandLoading event and then refreshing the [SfDataPager.PagedSource](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataPager.SfDataPager.html#Syncfusion_WinForms_DataPager_SfDataPager_PagedSource). This solution will resolve your issue.

 
 ```C#
 sfDataPager1.OnDemandLoading += SfDataPager1_OnDemandLoading;
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
 ```
 

Take a moment to peruse the [WinForms DataGrid - Paging documentation](https://help.syncfusion.com/windowsforms/datagrid/paging), where you can find about the basic details about paging the DataGrid.
