using SfDataGrid_Demo.Model;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SfDataGrid_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.MouseUp += DataGrid_OnMouseUp;
        }

        private void DataGrid_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            var point = e.GetPosition(this);
            var rowColumnIndex = dataGrid.GetVisualContainer().PointToCellRowColumnIndex(point);
            if (rowColumnIndex.ColumnIndex == 0 && rowColumnIndex.RowIndex == 0)
            {
                if (dataGrid.SelectedItems.Count  > 1)
                {
                    dataGrid.ClearSelections(false); // To clear all the selections
                }
                else
                {
                    dataGrid.SelectAll(); // To select all the Rows
                }                
            }             
        }
    }
}
