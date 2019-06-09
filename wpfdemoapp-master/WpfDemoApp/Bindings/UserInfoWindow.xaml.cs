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
using System.Windows.Shapes;

using System.Collections.ObjectModel;

namespace WpfDemoApp.Bindings
{
  /// <summary>
  /// Interaction logic for UserInfoWindow.xaml
  /// </summary>
  public partial class UserInfoWindow : Window
  {
    ObservableCollection<UserInfo> _list;

    public UserInfoWindow()
    {
      InitializeComponent();

      _list = new ObservableCollection<UserInfo>();
      _list.Add(new UserInfo("Tintin", 21, "Gold"));
      _list.Add(new UserInfo("Snowy", 11, "Brown"));
      _list.Add(new UserInfo("Haddock", 31, "Blue"));

      this.DataContext = _list;
    }

    private void AddNewUserButton_Click(object sender, RoutedEventArgs e)
    {
      _list.Add(new UserInfo(userNameTextBox.Text, Convert.ToInt32(ageTextBox.Text), favColorTextBox.Text));
    }
  }
}
