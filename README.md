# How to load Async Data in OnDemandLoading in WinForms DataGrid

In [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid), [SfDataPager.OnDemandLoading](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataPager.SfDataPager.html#Syncfusion_WinForms_DataPager_SfDataPager_OnDemandLoading) event does not support the async and await processes. Therefore, if you are using the await keyword to call a method, it may not work properly. However, you can overcome this issue by setting the [sfDataGrid.DataSource](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_DataSource) in the OnDemandLoading event and then refreshing the [SfDataPager.PagedSource](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataPager.SfDataPager.html#Syncfusion_WinForms_DataPager_SfDataPager_PagedSource). 

 
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

  ![SfDataGrid_DataPager_AsyncLoad.gif](https://support.syncfusion.com/kb/agent/attachment/article/15013/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE4NTM3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.uD9Rc-i6EH9kFgmtCFBxCv0Ixz5vBOUfIPksxFkD_MA)
 
Take a moment to peruse the [WinForms DataGrid - Paging documentation](https://help.syncfusion.com/windowsforms/datagrid/paging), where you can find about the basic details about paging the DataGrid.
