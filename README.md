# How-to-Select-All-the-Rows-Using-RowHeaderIndentCell-in-the-DataGrid
In a [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid){target="_blank"}, the default behavior does not allow for the selection of all rows when the `RowHeaderIndentCell` is clicked. However, you can implement this functionality by handling the `MouseUp` event. This event can be used to select all rows programmatically by accessing the row and column indices.

**C#**
 
 ```csharp
public MainWindow()
{
    InitializeComponent();
    dataGrid.MouseUp += DataGrid_MouseUp;
}

private void DataGrid_MouseUp(object sender, MouseButtonEventArgs e)
{
    var point = e.GetPosition(this);
    var rowColumnIndex = dataGrid.GetVisualContainer().PointToCellRowColumnIndex(point);
    if (rowColumnIndex.ColumnIndex == 0 && rowColumnIndex.RowIndex == 0)
    {
        if (dataGrid.SelectedItems.Count  > 1)
        {
            dataGrid.ClearSelections(false);
        }
        else
        {
            dataGrid.SelectAll(); 
        }     
    }          
} 
 ```
 
**Output**
![image.png](https://support.boldbi.com/kb/agent/attachment/article/16526/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI0OTk0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5ib2xkYmkuY29tIn0.Ae22-Z4LU0KuB5SuGY92QTxYOFFkCfDdoRdwZ_kJ2oo)

**Conclusion**

​I hope you enjoyed learning on how to select all the rows using the RowHeaderIndentCell(SfDataGrid).
You can refer to our [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid){target="_blank"} Control feature tour page to know about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/wpf/datagrid/getting-started){target="_blank"}, and how to quickly get started for configuration specifications.
For current customers, you can check out our components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense){target="_blank"} page. If you are new to Syncfusion, you can try our [30-day free](https://www.syncfusion.com/account/manage-trials/downloads){target="_blank"} trial to check out our other controls.

If you have any queries or require clarifications, please let us know in the comments section below. You can also contact us through our [support forums](https://www.syncfusion.com/forums){target="_blank"},[ Direct-Trac](https://support.syncfusion.com/create){target="_blank"}, or [feedback portal](https://www.syncfusion.com/feedback/wpf?control=sfdatagrid){target="_blank"}. We are always happy to assist you!
