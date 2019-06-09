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

namespace WpfDemoApp.Bindings
{
  /// <summary>
  /// Interaction logic for PersonWindow.xaml
  /// </summary>
  public partial class PersonWindow : Window
  {
    Person _person;
    public PersonWindow()
    {
      InitializeComponent();

      _person = new Person();
      _person.Age = 20;
      _person.Name = "Jughead";
      this.DataContext = _person;// the root window has the person object
    }

    private void ShowButton_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show($"Name: {_person.Name}\nAge: {_person.Age}");
    }

    private void AssignButton_Click(object sender, RoutedEventArgs e)
    {
      _person.Age = 21;
      _person.Name = "Archie";
    }
  }
}
