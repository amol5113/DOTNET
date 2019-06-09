using System;
using System.Collections.Generic;
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

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DisConnectedDBWpfApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    DataSet _northDS;

    SqlConnection _northCon;
    SqlDataAdapter _customersAdapter, _productsAdapter;
    public MainWindow()
    {
      InitializeComponent();
      this.Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      try
      {
        _northDS = new DataSet();

        _northCon = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthConnection"].ConnectionString);

        _customersAdapter = new SqlDataAdapter("Select * from Customers", _northCon);
        _customersAdapter.Fill(_northDS);

        _productsAdapter = new SqlDataAdapter("Select * from Products", _northCon);
        _productsAdapter.Fill(_northDS);



      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    private void GetTablesButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void GetCustomersButton_Click(object sender, RoutedEventArgs e)
    {
      customersComboBox.Items.Clear();
      try
      {
        for (int i = 0; i < _northDS.Tables[0].Rows.Count; i++)
        {
          customersComboBox.Items.Add($"{i + 1} == {_northDS.Tables[0].Rows[i][0]} == {_northDS.Tables[0].Rows[i][1]} == {_northDS.Tables[0].Rows[i][13]}");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }
  }
}
