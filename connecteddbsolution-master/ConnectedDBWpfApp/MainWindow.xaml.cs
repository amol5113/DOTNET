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

namespace ConnectedDBWpfApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {

    SqlConnection _northCon;

    public MainWindow()
    {
      InitializeComponent();
      this.Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      try
      {
        _northCon = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind; Integrated Security=true;");
        _northCon.Open();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    private void GetCustomersButton_Click(object sender, RoutedEventArgs e)
    {
      SqlCommand customersCMD = null;
      SqlDataReader customersReader = null;
      customersComboBox.Items.Clear();
      customesFieldsComboBox.Items.Clear();
      try
      {
        customersCMD = new SqlCommand("Select * from Customers", _northCon);
        customersReader = customersCMD.ExecuteReader();
        int ctr = 1;
        while (customersReader.Read())
        {
          customersComboBox.Items.Add($"{ctr++} == {customersReader.GetValue(0)} == {customersReader.GetString(1)} == {customersReader.GetValue(2)}");
        }

        for (int i = 0; i < customersReader.FieldCount; i++)
        {
          customesFieldsComboBox.Items.Add($"{i + 1} -- {customersReader.GetName(i)}");
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
      finally
      {
        if (!customersReader.IsClosed)
        {
          customersReader.Close();
        }
      }
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (_northCon.State == System.Data.ConnectionState.Open)
      {
        _northCon.Close();
        //MessageBox.Show("From Win Closing, Con Closed");
      }
    }

    private void GetProductsButton_Click(object sender, RoutedEventArgs e)
    {
      SqlCommand productsCMD = null;
      SqlDataReader productsReader = null;
      productsComboBox.Items.Clear();
      try
      {
        productsCMD = new SqlCommand("Select * from Products", _northCon);
        productsReader = productsCMD.ExecuteReader();
        int ctr = 1;
        while (productsReader.Read())
        {
          productsComboBox.Items.Add($"{ctr++} - {productsReader["ProductID"]} == {productsReader["ProductName"]} == {productsReader["UnitPrice"]}");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
      finally
      {
        if (!productsReader.IsClosed)
        {
          productsReader.Close();
        }
      }

    }

    private void GetMaxUnitPriceButton_Click(object sender, RoutedEventArgs e)
    {
      SqlCommand productsCMD = null;
      try
      {
        productsCMD = new SqlCommand("Select Max(UnitPrice) from Products");
        productsCMD.Connection = _northCon;
        unitPriceTextBlock.Text = productsCMD.ExecuteScalar().ToString();

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }

    }

    private void UpdateCustomerButton_Click(object sender, RoutedEventArgs e)
    {
      SqlCommand customersCMD = null;
      try
      {
        customersCMD = new SqlCommand($"Update Customers set CompanyName='{companyNameTextBox.Text}', ContactName='{contactNameTextBox.Text}' where CustomerID = '{customerIDTextBox.Text}'", _northCon);

        //MessageBox.Show(customersCMD.CommandText);
        int recEffected = customersCMD.ExecuteNonQuery();
        if (recEffected == 1)
        {
          MessageBox.Show("Customer Rec Updated....");
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
      finally
      {

      }
    }

    private void CustomersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (customersComboBox.Items.Count != 0)
      {
        string[] str = customersComboBox.SelectedItem.ToString().Split(new string[] { " == " }, StringSplitOptions.None);
        customerIDTextBox.Text = str[1];
        companyNameTextBox.Text = str[2];
        contactNameTextBox.Text = str[3];
      }
    }
  }
}
